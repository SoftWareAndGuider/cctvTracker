const PORT = process.env.PORT || 8080

const fs = require('fs')
const ejs = require('ejs')
const cors = require('cors')
const path = require('path').resolve()
const chalk = require('chalk')
const express = require('express')

const layout = {}
fs.readdir(path + '/layout', (err, files) => {
  if (err) console.log(chalk.red(err))
  files.forEach((file) => {
    layout[file] = fs.readFileSync(path + '/' + file)
  })
})

const app = express()
app.use(cors())

app.get('/api/data/:type', (req, res) => {
  console.log(chalk.yellow('/api/data/' + req.params.type) + ' | ' + chalk.magenta(req.ip))
  switch (req.params.type) {
    case 'cctv':
      res.send(require(path + '/data/cctv.json'))
      break

    case 'toilet':
      res.send(require(path + '/data/toilet.json'))
      break
    
    default:
      res.sendStatus(404)
      break
  }
})

app.get('/api/map/:type/:width/:height', (req, res) => {
  console.log(chalk.yellow('/api/map/' + req.params.type) + ' | ' + chalk.magenta(req.ip))

  switch (req.params.type) {
    case 'cctv':
      ejs.renderFile(path + '/api/cctv.ejs', { layout, mapH: req.params.height, mapW: req.params.width }, (err, str) => {
        if (err) console.log(chalk.red(err))
        else res.send(str)
      })
      break

      case 'toilet':
        ejs.renderFile(path + '/api/toilet.ejs', { layout, mapH: req.params.height, mapW: req.params.width }, (err, str) => {
          if (err) console.log(chalk.red(err))
          else res.send(str)
        })
        break

    default:
      res.sendStatus(404)
      break
  }
})

app.listen(PORT, () => {
  console.log(chalk.green('CCTV Tracker BackEnd Server is on http://localhost:') + chalk.green.bold(PORT))
})

const PORT = process.env.PORT || 3003

const fs = require('fs')
const ejs = require('ejs')
const cors = require('cors')
const path = require('path').resolve()
const chalk = require('chalk')
const express = require('express')

const layout = {}
layoutSync()

const app = express()
app.use(cors())

app.get('/favicon.ico', (req, res) => console.log(chalk.bgGreen.black('Browser Connection Sucessful (' + req.ip + ')')))

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

app.get('/', (_req, res) => res.redirect('/index'))

app.get('/:page', (req, res) => {
  layoutSync()
  ejs.renderFile(path + '/page/' + req.params.page + '.ejs', { layout }, (err, str) => {
    if (err) console.log(chalk.red(err))
    else res.send(str)
  })
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

    case 'wifi':
      ejs.renderFile(path + '/api/wifi.ejs', { layout, mapH: req.params.height, mapW: req.params.width }, (err, str) => {
        if (err) console.log(chalk.red(err))
        else res.send(str)
      })
      break
      
    case 'all':
      ejs.renderFile(path + '/api/all.ejs', { layout, mapH: req.params.height, mapW: req.params.width }, (err, str) => {
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
  console.log(chalk.green('The Data Map : 나를 도와줘 BackEnd Server is on http://localhost:') + chalk.green.bold(PORT))
})

function layoutSync () {
  fs.readdir(path + '/layout', (err, files) => {
    if (err) console.log(chalk.red(err))
    files.forEach((file) => {
      ejs.renderFile(path + '/layout/' + file, (err, str) => {
        if (err) console.log(chalk.red(err))
        console.log(chalk.blue('Load Layout') + ' | ' + chalk.magenta(file))
        layout[file.replace('.ejs', '')] = str
      })
    })
  })
}

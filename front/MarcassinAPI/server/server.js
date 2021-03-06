'use strict';

var loopback = require('loopback');
var boot = require('loopback-boot');
//var socketIO = require('socket.io');

var app = module.exports = loopback();

app.start = function() {
  // start the web server
  return app.listen(function() {
    app.emit('started');
    var baseUrl = app.get('url').replace(/\/$/, '');
    console.log('Web server listening at: %s', baseUrl);
    if (app.get('loopback-component-explorer')) {
      var explorerPath = app.get('loopback-component-explorer').mountPath;
      console.log('Browse your REST API at %s%s', baseUrl, explorerPath);
    }
  });
};

// Bootstrap the application, configure models, datasources and middleware.
// Sub-apps like REST API are mounted via boot scripts.
boot(app, __dirname, function(err) {
  if (err) throw err;

  // start the server if `$ node server.js`
  if (require.main === module){
		app.start();
	  /*app.io = require('socket.io')(app.start());
       //app.io.on('connection', function(socket){
		   socket.on('new_message', (content , idRoom, idUser) => {
			console.log('new_message in room ', idRoom , "by " , idUser ,"content : ", content)
			app.io.sockets.emit('new_message', content,idRoom, idUser)
			})
		console.log('a user connected');
		socket.on('disconnect', function(){
        console.log('user disconnected');
			});
			  // notify other clients that a new user has joined
			/*socket.broadcast.emit('user:join', {
				nom: nom,
				prenom: prenom
			});

			// broadcast a user's message to other users
			socket.on('send:message', function (data) {
				socket.broadcast.emit('send:message', {
					user: nom,
					text: data.message
				});
			});*/
	   //});

  }
});

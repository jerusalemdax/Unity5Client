module.exports = function(app) {
  return new Handler(app);
};

var Handler = function(app) {
  this.app = app;
};

Handler.prototype.version = function(msg, session, next) {
  next(null, {code: 200, msg: { version : 1}});
};

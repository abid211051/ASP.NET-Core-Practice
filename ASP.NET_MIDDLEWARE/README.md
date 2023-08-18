<h2>MiddleWare</h2>

-> Middleware is something which work in between our client and server request.

-> From client side we send request to server for some data or page using Http request pipeline,
and In between this server and client interaction, we can set middleware.

-> Middleware run on every request, if there is multiple middleware then after executing all middleware
ferther code will start to execute.

-> This middleware give more security to our server and Database

-> There are many In Built Middleware in ASP.NET Core. Even we can define our own custom middleware with custom
logic. For that we use "app.Use()" and "app.Run()".

-> app.Run() receive one parameter "HttpContext" and give response on our defined logic or code.

-> app.Use() overcome the limitation of app.Run(). We can use only one app.Run() for our custom middleware,
to execute next middleware we need one more parameter "next". But app.Run() only recive one parameter, so we can use
"next" in app.Run(), that's why we use app.Use() to define multiple middleware.

-> app.Use() receive two parameter. One is "HttpContext" to handle request, response for that middleware, and another 
one is "next" parameter to pass the "HttpContext" for next middleware. If we do not pass the "HttpContext" for next middleware
then executing middleware sequence will stop there.

-> Warning: Middleware execute in a sequential order, that means  those middleware will execute first, whose code is first in the
code file.

-> last app.Run() is used to run our server.

Example: Suppose user want to show some private data by requesting to server,
Now we don't want to accept any user request directly. We want to verify that user first
then if he/she is verified then we will let his/her request to further proccced.For this 
process we can set Middleware, which will check if user is authorized or not.

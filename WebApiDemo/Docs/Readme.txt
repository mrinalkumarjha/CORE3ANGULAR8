web api 2 docs

# Routing constraints

[Route("{id}")]   
[Route("{name}")] 

[Route("{id:int}")] : for int type param
[Route("{name:alpha}")]  : for alpha type param

[Route("{id:int:min(1)}")] :  this will map only iff id > 0


# IHttpActionResult vs HttpResponseMessage


IHttpActionResult  introduced in webapi 2,
it is a new type that a controller action method can return
namespace is system.web.http
HttpResponseMessage were used in webapi 1

benifits of IHttpActionResult  over HttpResponseMessage 

 1: code is cleaner and easier to read
 2: unit testing of controller action becomes much easier.

list of helper method that return a type that implement IHttpActionResult  
 > Ok()
 > NotFound()
 > BadRequest()
 > Unauthorized()
 > Created()
 > InternalServerError()

Ref: http://csharp-video-tutorials.blogspot.com/2017/02/ihttpactionresult-vs-httpresponsemessage.html

  ex: for return type IHttpActionResult  
   public IHttpActionResult Get()
    {
        return Ok(students);
    }

    public IHttpActionResult Get(int id)
    {
        var student = students.FirstOrDefault(s => s.Id == id);
        if (student == null)
        {
            //return NotFound();
            return Content(HttpStatusCode.NotFound, "Student not found");
        }

        return Ok(student);
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVC1.DataAccess; //DOUBT abt Data Access
using MVC1.Models.Database;


namespace WebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        DAL _dal = new DAL();

        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _dal.GetEmployees());
         }
        public HttpResponseMessage Get(long id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, _dal.GetEmployeeById(id));
        }
        public HttpResponseMessage Post(VolunteerTimeSheet bo)
        {
            return Request.CreateResponse(HttpStatusCode.OK, _dal.PostEmployee(bo));
        }
    }
}

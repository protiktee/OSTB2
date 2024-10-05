using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace OST_CORE_QA_API_2.Controllers
{
    [Route("api/[Controller]")]
    public class V2Controller : Controller
    {
        [HttpGet("QryOutData")]
        public IActionResult QryOperationSum([Required] int i, [Required] int j, string x)
        {
            string pServiceToken = "";
            if ((i + j) == 3)
            {
                pServiceToken = ServiceToken.GenerateServiceToken();
            } 
            else 
            {
                return Unauthorized();
            }
            return Ok(pServiceToken);
        }
        [HttpGet("ListQuestions")]
        public IActionResult ListQuestions()
        {
            DataTable dt = BaseQA.ListQuestions();
            var dbData = (from p in dt.AsEnumerable()
                          select new
                          {
                              QuestionID = p.Field<Int32>("QuestionID"),
                              QuestionTitle = p.Field<string>("QuestionTitle"),
                              QuestionDescription = p.Field<string>("QuestionDescription"),
                              MakeBy = p.Field<string>("MakeBy"),
                              MakeDate = p.Field<string>("MakeDate")
                          }).ToList();

            return Ok(dbData);
    }
    }
}

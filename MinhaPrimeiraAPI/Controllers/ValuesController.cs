using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;

namespace MinhaPrimeiraAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    //Get api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get() //Get() ou ObterTodos()
    {
        var valores = new string[] { "value1", "value2" };

        if (valores.Length < 5000)
            return BadRequest(); //Code 400

        return Ok(valores); //Code 200. O "Ok" está passando o objeto "valores" para o formato Jason.
    }

    [HttpGet("obter-valores")]
    public IEnumerable<string> ObterValores() //ObterValores() ou Get()
    {
        var valores = new string[] { "value1", "value2" };

        if (valores.Length < 5000)
            return null;

        return valores;
    }

    //Post api/values/obter-por-id/5
    [HttpGet("obter-por-id/{id:int}")]
    public ActionResult<string> Get(int id)
    {
        return "value";
    }

    //Post api/values
    [HttpPost]
    [ProducesResponseType(typeof(Product), StatusCodes.Status201Created)] //201:significa que a inserção foi realizada
    [ProducesResponseType(StatusCodes.Status400BadRequest)]// O que era para ser feito, não foi

    public ActionResult Post(Product product)
    {
        if (product.Id == 0) return BadRequest();

        //return Ok(product);//Retorna código 200
        return CreatedAtAction(actionName:"Post", product); //Retorna especificamente 201 + o produto adicionado, no formato Json
    }


    [HttpPut("{id}")]
    public void Put([FromRoute]int id, [FromForm] Product value) 
    {
        
    }

    //Delete api/values/5
    [HttpDelete("{id}")]
    public void Delete([FromQuery]int id)
    {

    }

    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

    }
}

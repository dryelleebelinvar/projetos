using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApiListaDeTarefas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListaDeTarefasController : ControllerBase
    {

        [HttpPost]
        public ListaDeTarefasResponse ProcessarInformacoesListaDeTarefas([FromBody] ListaDeTarefasRequest request)
        {
            var listaDeTarefasResponse = ProcessarInformacoesListaDeTarefas(request);

            return listaDeTarefasResponse;
        }
    }
}

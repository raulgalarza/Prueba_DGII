using DGII_CNTR.ContextDB;
using DGII_CNTR.Dtos;
using DGII_CNTR.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DGII_CNTR.Controllers
{
    [ApiController]
    [Route("api/contribuyente")]
    public class ContribuyentesController : ControllerBase
    {
        private readonly DgiiDbContext _context;
        public ContribuyentesController(DgiiDbContext context)
        {
            _context = context;
        }
        [HttpGet("contribuyentes")]
        public async Task<IActionResult> GetContribuyente()
        {

            var user = _context.Contribuyente.ToList();

            return Ok(user);

        }

        [HttpGet("comprobantes")]
        public async Task<IActionResult> GetComprobantes()
        {
            var factura = _context.comprobantesF.ToList();

            return Ok(factura);
        }



        [HttpGet("ContribuyentesComprobantes")]
        public async Task<IActionResult> GetContribuyentesComprobantes()
        {
            var contribuyentes = _context.Contribuyente.Include(c => c.ComprobantesFiscales).ToList();
            return Ok(contribuyentes);
        }


        [HttpGet("[action]/{cedula}")]
        public async Task <IActionResult> GetComprobantesFiscales(string cedula)
        {


            var suma = _context.comprobantesF.Where(x => x.rncCedula == cedula).Sum(a => a.itbis18);

            return Ok(suma);

        }
    }

}
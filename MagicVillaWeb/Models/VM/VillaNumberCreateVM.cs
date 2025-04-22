using MagicVillaWeb.Models.Dto;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MagicVillaWeb.Models.VM
{
    public class VillaNumberCreateVM
    {
        public VillaNumberCreateVM()
        {
            VillaNumber = new VillaNumberCreateDTO();
        }
        public VillaNumberCreateDTO VillaNumber { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> VillaList { get; set; }
    }
}

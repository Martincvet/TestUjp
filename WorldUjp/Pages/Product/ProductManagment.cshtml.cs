using System.Collections.Generic;
using System.Linq;
using Data.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WorldUjp.Pages.Product
{
    public class ProductManagmentModel : PageModel
    {
        private readonly ITaxPayerRepository taxPayer;
        private readonly IDDVRepository ddv;
        private readonly IProductRepository product;
        public ProductManagmentModel(ITaxPayerRepository taxPayer, IDDVRepository ddv, IProductRepository product)
        {
            this.taxPayer = taxPayer;
            this.ddv = ddv;
            this.product = product;
        }

        public IEnumerable<SelectListItem> DDVs { get; set; }
        [BindProperty]
        public Core.TaxPayer TaxPayer { get; set; }
        [BindProperty]
        public Core.Product Product { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
            {
                Product = new Core.Product();
                TaxPayer = taxPayer.Get(id.Value);
            }
            else
            {
                return RedirectToPage("/Shared/NotFound");
            }

            var listItems = ddv.GetAll().ToList().Select(d => new { Id = d.Id, Tax = $"{d.Tax}" });
            DDVs = new SelectList(listItems, "Id", "Tax");
            return Page();
        }
        public IActionResult OnPost(int id)
        {
            //if (!ModelState.IsValid)
            //    return RedirectToPage("/Shared/NotFound");

            TaxPayer = taxPayer.Get(id);

            if (Product.Id == 0)
            {
                Product = product.Create(Product);
                TaxPayer.Products.Add(Product);
            }
            else
            {
                return RedirectToPage("/Shared/NotFound");
            }

            product.Commit();

            var listItems = ddv.GetAll().ToList().Select(d => new { Id = d.Id, Tax = $"{d.Tax}" });
            DDVs = new SelectList(listItems, "Id", "Tax");
            return RedirectToPage("/TaxPayer/Products");
        }
    }
}

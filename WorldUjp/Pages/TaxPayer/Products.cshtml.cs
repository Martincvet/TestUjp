using Core;
using Data;
using Data.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace WorldUjp.Pages.TaxPayer
{
    public class ProductsModel : PageModel
    {
        private readonly ITaxPayerRepository context;
        public ProductsModel(ITaxPayerRepository context)
        {
            this.context = context;
        }

        [BindProperty]
        public Core.TaxPayer TaxPayer { get; set; }
        public void OnGet(int id)
        {
            TaxPayer = context.GetTaxPayer(id);
        }
    }
}

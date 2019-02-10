using CrudAspNetCoreDapper.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrudAspNetCoreDapper.Pages.Produto
{
    public class EditModel : PageModel
    {
        IProdutoRepository _produtoRepository;

        public EditModel(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [BindProperty]
        public Entities.Produto produto { get; set; }

        public void OnGet(int id)
        {
            produto = _produtoRepository.GetProdutoId(id);
        }

        public IActionResult OnPost()
        {
            var dados = produto;
            if (ModelState.IsValid)
            {
                var count = _produtoRepository.Edit(dados);
                if (count > 0)
                {
                    return RedirectToPage("/Produto/Index");
                }
            }
            return Page();
        }
    }
}
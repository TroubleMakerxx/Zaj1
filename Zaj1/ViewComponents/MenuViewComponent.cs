using Microsoft.AspNetCore.Mvc;
using Zaj1.Models;

namespace Zaj1.ViewComponents
{
    public class MenuViewComponent: ViewComponent
    {
        FilmyContext db;

        public MenuViewComponent(FilmyContext db)
        {
            this.db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("_Menu", db.Kategorie.ToList()));
        }
    }
}

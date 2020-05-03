using CetBookStore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.ViewComponents
{
    public class CategoryMenu2ViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext context;

        public CategoryMenu2ViewComponent(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var cats = await context.Categories.ToListAsync();
            return View(cats);
        }
    }
}

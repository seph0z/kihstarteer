using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Domain.Contracts
{
    public interface ICategoryService
    {
        List<SelectListItem> GetAll();
    }
}

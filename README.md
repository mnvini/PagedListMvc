# PagedListMvc
Simple project using pagedlist mvc

this project was create to show how simple is make a pagination using Paged List MVC

you have to download the reference paged list mvc on NuGet

after you create two variables in the Controller to define items per page and pagesNumber

like that

        public ActionResult Index(int? page)
        {
            int itemsPerPage = 10;
            int pageNumber = (page ?? 1);

            var listaFornecedor = _db.Fornecedores.ToList();

            return View(listaFornecedor.ToPagedList(pageNumber, itemsPerPage));
        }
        
And you have to put on the view IPagedList 

       PagedList.IPagedList<MyModel> 
       
passing your model

then you use this helper to create the pagination on index 

        @Html.PagedListPager(Model, page => Url.Action("Index",
         new { page}))

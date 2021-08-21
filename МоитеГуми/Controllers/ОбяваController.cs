namespace МоитеГуми.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using МоитеГуми.Models.Обява;
    using Microsoft.AspNetCore.Authorization;
    using МоитеГуми.Infrastructure;
    using МоитеГуми.Services.Obqwi;
    using МоитеГуми.Services.Dealers;

    public class ОбяваController : Controller
    {
        private readonly IDealerService dealers;
        private readonly IObqwiServices obqwi;

        public ОбяваController(
            IObqwiServices obqwi,
            IDealerService dealers)
        {
            this.obqwi = obqwi;
            this.dealers = dealers;
        }

        public IActionResult All([FromQuery] ObqwiSearchingModel query)
        {
            var queryResult = this.obqwi.All(
                query.Marka,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                ObqwiSearchingModel.ObqwiPerPage);

            var obqwiMarki = this.obqwi.AllMarki();

            query.CountObqwi = queryResult.CountObqwi;
            query.Marki = obqwiMarki;
            query.Obqwi = queryResult.Obqwa;

            return this.View(query);
        }

        [Authorize]
        public IActionResult Mine()
        {
            var myObqwi = this.obqwi.ByUser(this.User.Id());

            return View(myObqwi);
        }

        [Authorize]
        public IActionResult Delete()
        {

            return View();

        }

        [Authorize]
        public IActionResult Create()
        {
            if (!this.dealers.IsDealer(this.User.Id()))
            {
                return RedirectToAction(nameof(DealersController.Create), "Dealers");
            }
            //ot infrastrukture
            return View(new ObqwaModel
            {
                Categories = this.obqwi.AllCategories()//vieto shte ima info za kategoriite
            });
        }

        [HttpPost]
        [Authorize]
        public IActionResult Create(ObqwaModel obqva)
        {
            //var imageInmemory = new MemoryStream();
            //image.CopyTo(imageInmemory);
            //var imageBytes = imageInmemory.ToArray();



            //if (image == null || image.Length > 2 * 1024 * 1024)
            //{
            //    this.ModelState.AddModelError("Image", "The Image is too big");
            //}

            //IEnumerable<IformFile image za mnogo kartinki>

            var dealerId = this.dealers.IdByUser(this.User.Id());

            if (dealerId == 0)
            {
                return RedirectToAction(nameof(DealersController.Create), "Dealers");
            }

            if (!this.obqwi.CategoryExist(obqva.CategoryId))
            {
                this.ModelState.AddModelError(nameof(obqva.CategoryId), "Category is dont exist");
            }

            if (!ModelState.IsValid)
            {
                //IF NOT VALID PAK ПОКАЗЖА ЖИУТО ДА СЕ ПОПАЛНИ
                obqva.Categories = this.obqwi.AllCategories();

                return View(obqva);
            }

            this.obqwi.Create(
                obqva.Marka,
                obqva.Description,
                obqva.Year,
                obqva.CategoryId,
                obqva.ImageUrl,
                obqva.Size,
                dealerId);

            return RedirectToAction(nameof(All));// VINAGI REDIREKTVAME
        }

        [Authorize]
        public IActionResult Edit(int Id)
        {
            var userId = this.User.Id();

            if (!this.dealers.IsDealer(userId))
            {
                return RedirectToAction(nameof(DealersController.Create), "Dealers");
            }

            var currentObqwa = this.obqwi.Details(Id);

            if (currentObqwa.UserId != userId)
            {
                return Unauthorized();
            }

            return View(new ObqwaModel
            {
                Marka = currentObqwa.Marka,
                Description = currentObqwa.Description,
                Size = currentObqwa.Size,
                ImageUrl = currentObqwa.ImageUrl,
                Year = currentObqwa.Year,
                CategoryId = currentObqwa.CategoryId,
                Categories = this.obqwi.AllCategories()//vieto shte ima info za kategoriite
            });
        }

        [HttpPost]
        [Authorize]
        public IActionResult Edit(int Id, ObqwaModel obqva)
        {
            var dealerId = this.dealers.IdByUser(this.User.Id());

            if (dealerId == 0)
            {
                return RedirectToAction(nameof(DealersController.Create), "Dealers");
            }

            if (!this.obqwi.CategoryExist(obqva.CategoryId))
            {
                this.ModelState.AddModelError(nameof(obqva.CategoryId), "Category is dont exist");
            }

            if (!ModelState.IsValid)
            {
                //IF NOT VALID PAK ПОКАЗЖА ЖИУТО ДА СЕ ПОПАЛНИ
                obqva.Categories = this.obqwi.AllCategories();

                return View(obqva);
            }
            if (!this.obqwi.IsByDealer(Id, dealerId))
            {
                return BadRequest();
            }

             this.obqwi.Edit(
                     Id,
                     obqva.Marka,
                     obqva.Description,
                     obqva.Year,
                     obqva.CategoryId,
                     obqva.ImageUrl,
                     obqva.Size);


            return RedirectToAction(nameof(All));
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ComicBookGal.Models;
using ComicBookGal.Data;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

// Each Class should have its own concern

/*Separation of Concerns
 * - Help make our website easy to maintain
 * - If we need to change a data then we only need to d
 * Model - concerned about data and business logic
 * View - representation of model
 * Controller - process and request and responses
 */

namespace ComicBookGal.Controllers
{
    public class ComicBookGalleryController : Controller
    {
        // GET: /<controller>/

        private ComicBookRepository _comicBookRepository = null;

        public ComicBookGalleryController()
        {
            _comicBookRepository = new ComicBookRepository();    
        }

        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.getComicBooks();

            return View(comicBooks);
        }

        public ActionResult Detail(int? id){



            // coordinators, help specific actions to be performed
            // redirect Result - redirect user to different URL
            // viewBag - a built in system that helps carry data into the view from controller
            if(id == null){
                return StatusCode(404);
            }

            var comicBook = _comicBookRepository.getComicBook((int)id);

            // URL PATTERN - Controller/ACTION/ID

            // Update view to be strongly typed - MCV view that is associated with specific type
            // model instance through model property
            return View(comicBook);
        }
    }
}

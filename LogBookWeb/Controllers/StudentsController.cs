using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Logbook.Entities;
using Logbook.Repositories;
using LogBook.ViewModels;

namespace Logbook.MVCWebApp.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentRepository _repository;
        private readonly IGroupRepository _repositoryGroup;

        public StudentsController(IStudentRepository repository, IGroupRepository repositoryGroup)
        {
            _repository = repository;
            _repositoryGroup = repositoryGroup;
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            return View(await _repository.ToListAsync());
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _repository.GetItemAsync(id.Value);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        public async Task<IActionResult> Create()
        {
            StudentModel model = await _repository.CreateStudent(_repositoryGroup);
            return View(model);
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,GroupId")] StudentModel student)
        {
            if (ModelState.IsValid)
            {
                student.Id = Guid.NewGuid();
                await _repository.AddItemAsync(new Student
                    { FirstName = student.FirstName, LastName = student.LastName, GroupId = student.GroupId }
                );

                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _repository.GetItemAsync(id.Value);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("FirstName,LastName,Id")] Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                if (!await _repository.ChangeItemAsync(student))
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _repository.GetItemAsync(id.Value);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _repository.DeleteItemAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

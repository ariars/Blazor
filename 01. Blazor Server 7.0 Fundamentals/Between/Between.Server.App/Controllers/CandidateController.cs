﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Between.Server.App.Models.Candidates;

namespace Between.Server.App.Controllers
{
    public class CandidateController : Controller
    {
        private readonly CandidateDbContext _context;

        public CandidateController(CandidateDbContext context)
        {
            _context = context;
        }

        // GET: Candidate
        public async Task<IActionResult> Index()
        {
            return _context.Candidate != null ?
                        View(await _context.Candidate.ToListAsync()) :
                        Problem("Entity set 'CandidateDbContext.Candidate'  is null.");
        }

        // GET: Candidate/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Candidate == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidate
                .FirstOrDefaultAsync(m => m.Id == id);
            if (candidate == null)
            {
                return NotFound();
            }

            return View(candidate);
        }

        // GET: Candidate/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Candidate/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MiddleName,NameSuffix,AliasNames,SSN,Address,City,State,PostalCode,County,PrimaryPhone,SecondaryPhone,WorkPhone,Email,HomePhone,MobilePhone,DOB,Age,Gender,BirthCity,BirthState,BirthCounty,BirthCountry,DriverLicenseNumber,DriverLicenseState,DriverLicenseExpiration,Photo,LicenseNumber,OfficeAddress,OfficeCity,OfficeState,WorkFax,BirthPlace,UsCitizen,MaritalStatus,EyeColor,HairColor,Height,HeightFeet,HeightInches,BusinessStructure,BusinessStructureOther,Weight,PhysicalMarks,Id,FirstName,LastName,IsEnrollment")] Candidate candidate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(candidate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(candidate);
        }

        // GET: Candidate/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Candidate == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidate.FindAsync(id);
            if (candidate == null)
            {
                return NotFound();
            }
            return View(candidate);
        }

        // POST: Candidate/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MiddleName,NameSuffix,AliasNames,SSN,Address,City,State,PostalCode,County,PrimaryPhone,SecondaryPhone,WorkPhone,Email,HomePhone,MobilePhone,DOB,Age,Gender,BirthCity,BirthState,BirthCounty,BirthCountry,DriverLicenseNumber,DriverLicenseState,DriverLicenseExpiration,Photo,LicenseNumber,OfficeAddress,OfficeCity,OfficeState,WorkFax,BirthPlace,UsCitizen,MaritalStatus,EyeColor,HairColor,Height,HeightFeet,HeightInches,BusinessStructure,BusinessStructureOther,Weight,PhysicalMarks,Id,FirstName,LastName,IsEnrollment")] Candidate candidate)
        {
            if (id != candidate.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(candidate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CandidateExists(candidate.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(candidate);
        }

        // GET: Candidate/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Candidate == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidate
                .FirstOrDefaultAsync(m => m.Id == id);
            if (candidate == null)
            {
                return NotFound();
            }

            return View(candidate);
        }

        // POST: Candidate/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Candidate == null)
            {
                return Problem("Entity set 'CandidateDbContext.Candidate'  is null.");
            }
            var candidate = await _context.Candidate.FindAsync(id);
            if (candidate != null)
            {
                _context.Candidate.Remove(candidate);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CandidateExists(int id)
        {
            return (_context.Candidate?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

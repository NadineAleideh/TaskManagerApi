using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManagerApi.Data;
using TaskManagerApi.Interface;
using TaskManagerApi.Models;
using TaskManagerApi.Models.Dto;


namespace TaskManagerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITsk _task;

        public TaskController(ITsk task)
        {
            _task = task;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tasksList = await _task.GetAll();
            return Ok(tasksList);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var taskById = await _task.GetById(id);
            return Ok(taskById);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] TskDto tsk)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var addedTask = await _task.Add(tsk);
            return CreatedAtAction(nameof(GetById), new { id = addedTask.Id }, addedTask);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] TskDto tsk)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var editedTask = await _task.Edit(id, tsk);
            return Ok(editedTask);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var taskToDelete = await _task.Delete(id);
            return NoContent();
        }
    }
}

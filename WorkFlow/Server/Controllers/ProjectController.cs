using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkFlow.Shared.Dto;
using WorkFlow.Shared.Interfaces;

namespace WorkFlow.Server.Controllers {
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase {

        public ProjectController(IProject projectModel) {
            ProjectModel = projectModel;
        }

        [Inject]
        protected IProject ProjectModel { get; set; }

        // GET: api/project
        [HttpGet]
        public async Task<IActionResult> Get() {
            try
            {
                List<ProjectDto> companies = await ProjectModel.List();
                return Ok(companies);
            }
            catch (Exception e)
            {
                return e switch
                {
                    InvalidDataException => BadRequest(e.Message),
                    UnauthorizedAccessException => Unauthorized(e.Message),
                    _ => e is DbUpdateException ? BadRequest(e.Message) : StatusCode(500, "Something went wrong")
                };
            }
        }

        // GET: api/project/company/{companyID}
        [HttpGet("company/{companyId:guid}")]
        public async Task<IActionResult> GetByCompany(Guid companyId) {
            try
            {
                List<ProjectDto> companies = await ProjectModel.List(companyId);
                return Ok(companies);
            }
            catch (Exception e)
            {
                return e switch
                {
                    InvalidDataException => BadRequest(e.Message),
                    UnauthorizedAccessException => Unauthorized(e.Message),
                    _ => e is DbUpdateException ? BadRequest(e.Message) : StatusCode(500, "Something went wrong")
                };
            }
        }

        // GET: api/project/5
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Get(Guid id) {
            try
            {
                ProjectDto project = await ProjectModel.Get(id);
                return Ok(project);
            }
            catch (Exception e)
            {
                return e switch
                {
                    InvalidDataException => BadRequest(e.Message),
                    UnauthorizedAccessException => Unauthorized(e.Message),
                    _ => e is DbUpdateException ? BadRequest(e.Message) : StatusCode(500, "Something went wrong")
                };
            }
        }

        // GET: api/project/{companyUri}/{projectUri}
        [HttpGet("{companyUri}/{projectUri}")]
        public async Task<IActionResult> Get(String companyUri, String projectUri) {
            try
            {
                ProjectDto project = await ProjectModel.Get(companyUri, projectUri);
                return Ok(project);
            }
            catch (Exception e)
            {
                return e switch
                {
                    InvalidDataException => BadRequest(e.Message),
                    UnauthorizedAccessException => Unauthorized(e.Message),
                    _ => e is DbUpdateException ? BadRequest(e.Message) : StatusCode(500, "Something went wrong")
                };
            }
        }

        // POST: api/project
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProjectDto project) {
            try
            {
                ProjectDto newProject = await ProjectModel.Create(project);
                return Ok(newProject);
            }
            catch (Exception e)
            {
                return e switch
                {
                    InvalidDataException => BadRequest(e.Message),
                    UnauthorizedAccessException => Unauthorized(e.Message),
                    _ => e is DbUpdateException ? BadRequest(e.Message) : StatusCode(500, $"Something went wrong: {e.Message}")
                };
            }
        }

        // PUT: api/project/5
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] ProjectDto project) {
            try
            {
                ProjectDto updatedProject = await ProjectModel.Update(id, project);
                return Ok(updatedProject);
            }
            catch (Exception e)
            {
                return e switch
                {
                    InvalidDataException => BadRequest(e.Message),
                    UnauthorizedAccessException => Unauthorized(e.Message),
                    _ => e is DbUpdateException ? BadRequest(e.Message) : StatusCode(500, $"Something went wrong: {e.Message}")
                };
            }
        }

        // PATCH: api/project/5
        [HttpPatch("{id:guid}")]
        [Obsolete("Use PUT: api/user/project")]
        public async Task<IActionResult> Patch(Guid id, [FromBody] UserDto user) {
            try
            {
                ProjectDto project = await ProjectModel.ModifyUser(id, user);
                return Ok(project);
            }
            catch (Exception e)
            {
                return e switch
                {
                    InvalidDataException => BadRequest(e.Message),
                    UnauthorizedAccessException => Unauthorized(e.Message),
                    _ => e is DbUpdateException ? BadRequest(e.Message) : StatusCode(500, "Something went wrong")
                };
            }
        }

        // DELETE: api/project/5
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id) {
            try
            {
                Boolean deleted = await ProjectModel.Delete(id);
                return Ok(deleted);
            }
            catch (Exception e)
            {
                return e switch
                {
                    InvalidDataException => BadRequest(e.Message),
                    UnauthorizedAccessException => Unauthorized(e.Message),
                    _ => e is DbUpdateException ? BadRequest(e.Message) : StatusCode(500, "Something went wrong")
                };
            }
        }
    }
}

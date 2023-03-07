/*
 * Simple emlpoyee contract tracker api
 *
 * This API allows management of client contracts and tracks history of employee contract assignments 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using SimpleTracker.Api.Attributes;
using SimpleTracker.Api.Models;

namespace SimpleTracker.Api.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class DefaultApiController : ControllerBase
    { 
        /// <summary>
        /// Delete a client by ID
        /// </summary>
        /// <param name="clientId">Numeric ID of the client</param>
        /// <response code="200">OK</response>
        [HttpDelete]
        [Route("/clients/{clientId}")]
        [ValidateModelState]
        [SwaggerOperation("ClientsClientIdDelete")]
        public virtual IActionResult ClientsClientIdDelete([FromRoute (Name = "clientId")][Required]int clientId)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a client by ID
        /// </summary>
        /// <param name="clientId">Numeric ID of the client</param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/clients/{clientId}")]
        [ValidateModelState]
        [SwaggerOperation("ClientsClientIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(ModelClient), description: "OK")]
        public virtual IActionResult ClientsClientIdGet([FromRoute (Name = "clientId")][Required]int clientId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ModelClient));
            string exampleJson, rawJson = null;
            rawJson = System.IO.File.ReadAllText(@"sample.json");
            dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(rawJson); 
            exampleJson = result.clients[clientId].ToString();
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ModelClient>(exampleJson)
            : default(ModelClient);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Update a client by ID
        /// </summary>
        /// <param name="clientId">Numeric ID of the client</param>
        /// <param name="clientsPostRequest"></param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/clients/{clientId}")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("ClientsClientIdPut")]
        [SwaggerResponse(statusCode: 200, type: typeof(ModelClient), description: "OK")]
        public virtual IActionResult ClientsClientIdPut([FromRoute (Name = "clientId")][Required]int clientId, [FromBody]ClientsPostRequest clientsPostRequest)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ModelClient));
            string exampleJson, rawJson = null;
            rawJson = System.IO.File.ReadAllText(@"sample.json");
            dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(rawJson); 
            exampleJson = result.clients.ToString();
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ModelClient>(exampleJson)
            : default(ModelClient);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get all clients
        /// </summary>
        /// <remarks>Retrieves all clients</remarks>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/clients")]
        [ValidateModelState]
        [SwaggerOperation("ClientsGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<ModelClient>), description: "OK")]
        public virtual IActionResult ClientsGet()
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<ModelClient>));
            string exampleJson, rawJson = null;
            rawJson = System.IO.File.ReadAllText(@"sample.json");
            dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(rawJson); 
            exampleJson = result.clients.ToString();
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<ModelClient>>(exampleJson)
            : default(List<ModelClient>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Create new client
        /// </summary>
        /// <remarks>Add a new client with given name and url</remarks>
        /// <param name="clientsPostRequest"></param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/clients")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("ClientsPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(ModelClient), description: "OK")]
        public virtual IActionResult ClientsPost([FromBody]ClientsPostRequest clientsPostRequest)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ModelClient));
            string exampleJson, rawJson = null;
            rawJson = System.IO.File.ReadAllText(@"sample.json");
            dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(rawJson); 
            exampleJson = result.clients.ToString();
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ModelClient>(exampleJson)
            : default(ModelClient);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Delete a contract by ID
        /// </summary>
        /// <param name="contractId">Numeric ID of the contract</param>
        /// <response code="200">OK</response>
        [HttpDelete]
        [Route("/contracts/{contractId}")]
        [ValidateModelState]
        [SwaggerOperation("ContractsContractIdDelete")]
        public virtual IActionResult ContractsContractIdDelete([FromRoute (Name = "contractId")][Required]int contractId)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a contract by ID
        /// </summary>
        /// <param name="contractId">Numeric ID of the contract</param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/contracts/{contractId}")]
        [ValidateModelState]
        [SwaggerOperation("ContractsContractIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Contract), description: "OK")]
        public virtual IActionResult ContractsContractIdGet([FromRoute (Name = "contractId")][Required]int contractId)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Contract));
            string exampleJson = null;
            exampleJson = "{\n  \"tech\" : [ \"tech\", \"tech\" ],\n  \"clientId\" : 6,\n  \"endDate\" : \"endDate\",\n  \"id\" : 0,\n  \"type\" : \"type\",\n  \"startDate\" : \"startDate\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Contract>(exampleJson)
            : default(Contract);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Update a contract by ID
        /// </summary>
        /// <param name="contractId">Numeric ID of the contract</param>
        /// <param name="contractPatch"></param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/contracts/{contractId}")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("ContractsContractIdPut")]
        [SwaggerResponse(statusCode: 200, type: typeof(Contract), description: "OK")]
        public virtual IActionResult ContractsContractIdPut([FromRoute (Name = "contractId")][Required]int contractId, [FromBody]ContractPatch contractPatch)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Contract));
            string exampleJson = null;
            exampleJson = "{\n  \"tech\" : [ \"tech\", \"tech\" ],\n  \"clientId\" : 6,\n  \"endDate\" : \"endDate\",\n  \"id\" : 0,\n  \"type\" : \"type\",\n  \"startDate\" : \"startDate\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Contract>(exampleJson)
            : default(Contract);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get all contracts
        /// </summary>
        /// <remarks>Retrieves all contracts</remarks>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/contracts")]
        [ValidateModelState]
        [SwaggerOperation("ContractsGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Contract>), description: "OK")]
        public virtual IActionResult ContractsGet()
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Contract>));
            string exampleJson = null;
            exampleJson = "[ {\n  \"tech\" : [ \"tech\", \"tech\" ],\n  \"clientId\" : 6,\n  \"endDate\" : \"endDate\",\n  \"id\" : 0,\n  \"type\" : \"type\",\n  \"startDate\" : \"startDate\"\n}, {\n  \"tech\" : [ \"tech\", \"tech\" ],\n  \"clientId\" : 6,\n  \"endDate\" : \"endDate\",\n  \"id\" : 0,\n  \"type\" : \"type\",\n  \"startDate\" : \"startDate\"\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Contract>>(exampleJson)
            : default(List<Contract>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Create new contract
        /// </summary>
        /// <remarks>Add a new contract with fields</remarks>
        /// <param name="contractPatch"></param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/contracts")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("ContractsPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(Contract), description: "OK")]
        public virtual IActionResult ContractsPost([FromBody]ContractPatch contractPatch)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Contract));
            string exampleJson = null;
            exampleJson = "{\n  \"tech\" : [ \"tech\", \"tech\" ],\n  \"clientId\" : 6,\n  \"endDate\" : \"endDate\",\n  \"id\" : 0,\n  \"type\" : \"type\",\n  \"startDate\" : \"startDate\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Contract>(exampleJson)
            : default(Contract);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Delete an employee by ID
        /// </summary>
        /// <param name="employeeId">Numeric ID of the employee</param>
        /// <response code="200">OK</response>
        [HttpDelete]
        [Route("/employees/{employeeId}")]
        [ValidateModelState]
        [SwaggerOperation("EmployeesEmployeeIdDelete")]
        public virtual IActionResult EmployeesEmployeeIdDelete([FromRoute (Name = "employeeId")][Required]int employeeId)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Get an employee by ID
        /// </summary>
        /// <param name="employeeId">Numeric ID of the employee</param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/employees/{employeeId}")]
        [ValidateModelState]
        [SwaggerOperation("EmployeesEmployeeIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Employee), description: "OK")]
        public virtual IActionResult EmployeesEmployeeIdGet([FromRoute (Name = "employeeId")][Required]int employeeId)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Employee));
            string exampleJson = null;
            exampleJson = "{\n  \"github\" : \"github\",\n  \"name\" : \"name\",\n  \"id\" : 0\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Employee>(exampleJson)
            : default(Employee);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Update an employee by ID
        /// </summary>
        /// <param name="employeeId">Numeric ID of the employee</param>
        /// <param name="employeesPostRequest"></param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/employees/{employeeId}")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("EmployeesEmployeeIdPut")]
        [SwaggerResponse(statusCode: 200, type: typeof(Employee), description: "OK")]
        public virtual IActionResult EmployeesEmployeeIdPut([FromRoute (Name = "employeeId")][Required]int employeeId, [FromBody]EmployeesPostRequest employeesPostRequest)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Employee));
            string exampleJson = null;
            exampleJson = "{\n  \"github\" : \"github\",\n  \"name\" : \"name\",\n  \"id\" : 0\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Employee>(exampleJson)
            : default(Employee);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get all employees
        /// </summary>
        /// <remarks>Retrieves all employees</remarks>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/employees")]
        [ValidateModelState]
        [SwaggerOperation("EmployeesGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Employee>), description: "OK")]
        public virtual IActionResult EmployeesGet()
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Employee>));
            string exampleJson = null;
            exampleJson = "[ {\n  \"github\" : \"github\",\n  \"name\" : \"name\",\n  \"id\" : 0\n}, {\n  \"github\" : \"github\",\n  \"name\" : \"name\",\n  \"id\" : 0\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Employee>>(exampleJson)
            : default(List<Employee>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Create new employee
        /// </summary>
        /// <remarks>Add a new employee with given name and github username</remarks>
        /// <param name="employeesPostRequest"></param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/employees")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("EmployeesPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(Employee), description: "OK")]
        public virtual IActionResult EmployeesPost([FromBody]EmployeesPostRequest employeesPostRequest)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Employee));
            string exampleJson = null;
            exampleJson = "{\n  \"github\" : \"github\",\n  \"name\" : \"name\",\n  \"id\" : 0\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Employee>(exampleJson)
            : default(Employee);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get all history
        /// </summary>
        /// <remarks>Retrieves all employee contract assignment history</remarks>
        /// <param name="employeeId">numerical employee identifier</param>
        /// <param name="clientId">numerical client identifier</param>
        /// <param name="contractId">numerical contract identifier</param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/history")]
        [ValidateModelState]
        [SwaggerOperation("HistoryGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<History>), description: "OK")]
        public virtual IActionResult HistoryGet([FromQuery (Name = "employeeId")]int? employeeId, [FromQuery (Name = "clientId")]int? clientId, [FromQuery (Name = "contractId")]int? contractId)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<History>));
            string exampleJson = null;
            exampleJson = "[ {\n  \"employeeName\" : \"employeeName\",\n  \"clientId\" : 6,\n  \"role\" : \"role\",\n  \"clientName\" : \"clientName\",\n  \"contractId\" : 1,\n  \"employeeId\" : 5,\n  \"id\" : 0\n}, {\n  \"employeeName\" : \"employeeName\",\n  \"clientId\" : 6,\n  \"role\" : \"role\",\n  \"clientName\" : \"clientName\",\n  \"contractId\" : 1,\n  \"employeeId\" : 5,\n  \"id\" : 0\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<History>>(exampleJson)
            : default(List<History>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Delete an employee contract assignment by ID
        /// </summary>
        /// <param name="historyId">Numeric ID of the employee contract assignment</param>
        /// <response code="200">OK</response>
        [HttpDelete]
        [Route("/history/{historyId}")]
        [ValidateModelState]
        [SwaggerOperation("HistoryHistoryIdDelete")]
        public virtual IActionResult HistoryHistoryIdDelete([FromRoute (Name = "historyId")][Required]int historyId)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Get an employee contract asignment by ID
        /// </summary>
        /// <param name="historyId">Numeric ID of the employee contract assignment</param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/history/{historyId}")]
        [ValidateModelState]
        [SwaggerOperation("HistoryHistoryIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(History), description: "OK")]
        public virtual IActionResult HistoryHistoryIdGet([FromRoute (Name = "historyId")][Required]int historyId)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(History));
            string exampleJson = null;
            exampleJson = "{\n  \"employeeName\" : \"employeeName\",\n  \"clientId\" : 6,\n  \"role\" : \"role\",\n  \"clientName\" : \"clientName\",\n  \"contractId\" : 1,\n  \"employeeId\" : 5,\n  \"id\" : 0\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<History>(exampleJson)
            : default(History);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Update an employee contract assignment by ID
        /// </summary>
        /// <param name="historyId">Numeric ID of the employee contract assignment</param>
        /// <param name="historyPatch"></param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/history/{historyId}")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("HistoryHistoryIdPut")]
        [SwaggerResponse(statusCode: 200, type: typeof(Contract), description: "OK")]
        public virtual IActionResult HistoryHistoryIdPut([FromRoute (Name = "historyId")][Required]int historyId, [FromBody]HistoryPatch historyPatch)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Contract));
            string exampleJson = null;
            exampleJson = "{\n  \"tech\" : [ \"tech\", \"tech\" ],\n  \"clientId\" : 6,\n  \"endDate\" : \"endDate\",\n  \"id\" : 0,\n  \"type\" : \"type\",\n  \"startDate\" : \"startDate\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Contract>(exampleJson)
            : default(Contract);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Create new employee contract assignment
        /// </summary>
        /// <remarks>Add a new contract assignment with fields</remarks>
        /// <param name="historyPatch"></param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/history")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("HistoryPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(History), description: "OK")]
        public virtual IActionResult HistoryPost([FromBody]HistoryPatch historyPatch)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(History));
            string exampleJson = null;
            exampleJson = "{\n  \"employeeName\" : \"employeeName\",\n  \"clientId\" : 6,\n  \"role\" : \"role\",\n  \"clientName\" : \"clientName\",\n  \"contractId\" : 1,\n  \"employeeId\" : 5,\n  \"id\" : 0\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<History>(exampleJson)
            : default(History);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}

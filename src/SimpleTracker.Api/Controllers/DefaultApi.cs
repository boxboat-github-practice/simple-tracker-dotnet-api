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
        static string rawJson;
        static List<ModelClient> clients;

        static List<Employee> employees;
        static List<Contract> contracts;

        static List<History> histories;
        static HashSet<int> generatedIds;
        static DefaultApiController ()
        {
            rawJson = System.IO.File.ReadAllText(@"sample.json");
            dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(rawJson);

            clients = result.clients.ToString() != null
            ? JsonConvert.DeserializeObject<List<ModelClient>>(result.clients.ToString())
            : default(List<ModelClient>);

            employees = result.employees.ToString() != null
            ? JsonConvert.DeserializeObject<List<Employee>>(result.employees.ToString())
            : default(List<Employee>);

            contracts = result.contracts.ToString() != null
            ? JsonConvert.DeserializeObject<List<Contract>>(result.contracts.ToString())
            : default(List<Contract>);

             histories = result.history.ToString() != null
            ? JsonConvert.DeserializeObject<List<History>>(result.history.ToString())
            : default(List<History>);
            
            generatedIds = new HashSet<int>();
        }

        static int GetNewID()
        {
            Random rnd = new Random();
            int testRand = rnd.Next(256, 512);

            while(generatedIds.Contains(testRand))
            {
                testRand = rnd.Next(256, 512);
            }
            return testRand;
        }

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
            // return StatusCode(200)

            var clientToDelete = clients.Find(i => i.Id == clientId);
            clients.Remove(clientToDelete);
            
            return StatusCode(200);
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
            var clientToFind = clients.Find(i => i.Id == clientId);
            
            return new ObjectResult(clientToFind);
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
            var clientToChange = clients.Find(i => i.Id == clientId);
            clientToChange.Name = clientsPostRequest.Name;
            clientToChange.Url = clientsPostRequest.Url;

            var updatedClient = clientToChange.ToJson() != null
            ? JsonConvert.DeserializeObject<ModelClient>(clientToChange.ToJson())
            : default(ModelClient);

            return new ObjectResult(updatedClient);
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
            return new ObjectResult(clients);
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
            ModelClient mc = new ModelClient();
            mc.Id = GetNewID();
            mc.Name = clientsPostRequest.Name;
            mc.Url = clientsPostRequest.Url;

            clients.Add(mc);

            string newClientJson = null;
            newClientJson = mc.ToJson();
            
            var newClient = newClientJson != null
            ? JsonConvert.DeserializeObject<ModelClient>(newClientJson)
            : default(ModelClient);
    
            return new ObjectResult(newClient);
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

            var contractToDelete = contracts.Find(i => i.Id == contractId);
            contracts.Remove(contractToDelete);
            
            return StatusCode(200);
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
            var contractToFind = contracts.Find(i => i.Id == contractId);
            
            return new ObjectResult(contractToFind);
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
            var contractToChange = contracts.Find(i => i.Id == contractId);
            contractToChange.EndDate = contractPatch.EndDate;
            contractToChange.StartDate = contractPatch.StartDate;
            contractToChange.Tech = contractPatch.Tech;

            var updatedContract = contractToChange.ToJson() != null
            ? JsonConvert.DeserializeObject<Contract>(contractToChange.ToJson())
            : default(Contract);

            return new ObjectResult(updatedContract);
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
            return new ObjectResult(contracts);
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
            Contract c = new Contract();
            c.Id = GetNewID();
            c.ClientId = contractPatch.ClientId;
            c.EndDate = contractPatch.EndDate;
            c.StartDate = contractPatch.StartDate;
            c.Tech = contractPatch.Tech;

            contracts.Add(c);

            string newContractJson = null;
            newContractJson = c.ToJson();
            
            var newContract = newContractJson != null
            ? JsonConvert.DeserializeObject<Contract>(newContractJson)
            : default(Contract);
    
            return new ObjectResult(newContract);
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

            var employeeToDelete = employees.Find(i => i.Id == employeeId);
            employees.Remove(employeeToDelete);
            
            return StatusCode(200);
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
            var employeeToFind = employees.Find(i => i.Id == employeeId);
            
            return new ObjectResult(employeeToFind);
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
            var employeeToChange = employees.Find(i => i.Id == employeeId);
            employeeToChange.Github = employeesPostRequest.Github;
            employeeToChange.Name = employeesPostRequest.Name;

            var updatedEmployee = employeeToChange.ToJson() != null
            ? JsonConvert.DeserializeObject<Employee>(employeeToChange.ToJson())
            : default(Employee);

            return new ObjectResult(updatedEmployee);
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
            return new ObjectResult(employees);
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
            Employee e = new Employee();
            e.Id = GetNewID();
            e.Github = employeesPostRequest.Github;
            e.Name = employeesPostRequest.Name;

            employees.Add(e);
            
            string newEmployeeJson = null;
            newEmployeeJson = e.ToJson();
            
            var newEmployee = newEmployeeJson != null
            ? JsonConvert.DeserializeObject<Employee>(newEmployeeJson)
            : default(Employee);
    
            return new ObjectResult(newEmployee);
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
            return new ObjectResult(histories);
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

            var historyToDelete = histories.Find(i => i.Id == historyId);
            histories.Remove(historyToDelete);
            
            return StatusCode(200);
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
            var historyToFind = histories.Find(i => i.Id == historyId);
            
            return new ObjectResult(historyToFind);
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

            var historyToChange = histories.Find(i => i.Id == historyId);
            historyToChange.ClientId = historyPatch.ClientId;
            historyToChange.ContractId = historyPatch.ContractId;
            historyToChange.EmployeeId = historyPatch.EmployeeId;
            historyToChange.Role = historyPatch.Role;

            var updatedHistory = historyToChange.ToJson() != null
            ? JsonConvert.DeserializeObject<History>(historyToChange.ToJson())
            : default(History);

            return new ObjectResult(updatedHistory);
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
            History h = new History();
            h.Id = GetNewID();
            h.ClientId = historyPatch.ClientId;
            h.ClientName = "Client Name";
            h.ContractId = historyPatch.ContractId;
            h.EmployeeId = historyPatch.EmployeeId;
            h.EmployeeName = "Employee Name";
            h.Role = historyPatch.Role;

            histories.Add(h);
            
            string newHistoryJson = null;
            newHistoryJson = h.ToJson();
            
            var newHistory = newHistoryJson != null
            ? JsonConvert.DeserializeObject<History>(newHistoryJson)
            : default(History);
    
            return new ObjectResult(newHistory);
        }
    }
}

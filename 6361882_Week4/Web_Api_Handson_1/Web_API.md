Web API Hands-on Report

1. RESTful Web Service, Web API, & Microservice

- REST: Representational State Transfer (stateless, uses HTTP, resource-based URLs)
- Features: Stateless, message-based, not restricted to XML (JSON, etc.)
- Microservice: Small, independently deployable service units.
- WebService vs WebAPI: WebAPI is lighter, can return multiple formats, and integrates easily with HTTP verbs.

---

2. HttpRequest & HttpResponse

- HttpRequest: Incoming HTTP request data (method, headers, body).
- HttpResponse: Outgoing response sent back (status code, body, headers).

---

3. Action Verbs

- HttpGet: Get data.
- HttpPost: Create new data.
- HttpPut: Update existing data.
- HttpDelete: Delete data.
- Declared using attributes `[HttpGet]` etc. above controller actions.

---

4. HttpStatusCodes

- `Ok (200)`
- `BadRequest (400)`
- `Unauthorized (401)`
- `InternalServerError (500)`

---

5. Simple Web API

- `ValuesController` inherits `ApiController`
- Defines `GET`, `POST` methods.
- Uses `[HttpGet]`, `[HttpPost]` attributes.

---

6. Config Files

- Startup.cs: Dependency Injection, routing.
- appsettings.json: App configs like DB connection strings.
- launchSettings.json: Profiles for running locally.
- Route.config & WebAPI.config: Used in .NET Framework (4.5) for route definitions.

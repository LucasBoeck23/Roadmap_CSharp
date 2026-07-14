# 🗺️ Roadmap C# / .NET — De Trainee a Sênior

> Guia de estudos focado no que o mercado realmente pede.
> Cada tópico será documentado com exemplos práticos neste repositório.

---

## 📌 Como usar este roadmap

- ✅ = Já sei / concluído
- 🔄 = Estudando agora
- ⬜ = Ainda não comecei

---

## 🟢 Nível 1 — Trainee / Estagiário

> Fundamentos da linguagem C# e do ecossistema .NET.
> (Você já sabe POO, então pode marcar ✅ nos itens de OOP e focar no que é específico de C#)

### 1.1 Fundamentos do C#

| # | Tópico | Status |
|---|--------|--------|
| 1 | Tipos de valor vs tipos de referência (value types vs reference types) | ⬜ |
| 2 | Nullable types (`int?`, `string?`) e null safety | ⬜ |
| 3 | Strings: interpolação, `StringBuilder`, `Span<char>` | ⬜ |
| 4 | Arrays, Listas, Dicionários e coleções genéricas | ⬜ |
| 5 | Enums e Structs | ⬜ |
| 6 | Tuplas e Deconstruction | ⬜ |
| 7 | Pattern Matching (`is`, `switch` expressions) | ⬜ |
| 8 | Exceções e tratamento de erros (`try/catch/finally`, custom exceptions) | ⬜ |
| 9 | Namespaces e organização de projetos | ⬜ |
| 10 | `var`, `dynamic` e `object` — quando usar cada um | ⬜ |

### 1.2 POO em C# (revisar com foco na sintaxe C#)

| # | Tópico | Status |
|---|--------|--------|
| 1 | Classes, records e structs | ⬜ |
| 2 | Interfaces e classes abstratas | ⬜ |
| 3 | Herança e polimorfismo | ⬜ |
| 4 | Encapsulamento: properties, `init`, `required` | ⬜ |
| 5 | Generics (`<T>`) e constraints | ⬜ |
| 6 | Delegates, Events e Lambdas | ⬜ |
| 7 | Extension Methods | ⬜ |
| 8 | Operator Overloading | ⬜ |

### 1.3 Ferramentas e Ambiente

| # | Tópico | Status |
|---|--------|--------|
| 1 | .NET CLI (`dotnet new`, `dotnet run`, `dotnet build`) | ⬜ |
| 2 | Estrutura de um projeto .NET (`.csproj`, `Program.cs`) | ⬜ |
| 3 | NuGet — gerenciador de pacotes | ⬜ |
| 4 | Git + GitHub (versionamento) | ⬜ |
| 5 | Visual Studio / VS Code / Rider | ⬜ |
| 6 | Debugging (breakpoints, watch, call stack) | ⬜ |

---

## 🔵 Nível 2 — Júnior

> Construindo aplicações reais com ASP.NET Core e banco de dados.

### 2.1 LINQ (Language Integrated Query)

| # | Tópico | Status |
|---|--------|--------|
| 1 | Sintaxe de método vs sintaxe de query | ⬜ |
| 2 | `Where`, `Select`, `OrderBy`, `GroupBy` | ⬜ |
| 3 | `First`, `Single`, `Any`, `All`, `Count` | ⬜ |
| 4 | `Join`, `SelectMany`, `Aggregate` | ⬜ |
| 5 | Deferred Execution vs Immediate Execution | ⬜ |
| 6 | LINQ com coleções complexas (objetos aninhados) | ⬜ |

### 2.2 Programação Assíncrona

| # | Tópico | Status |
|---|--------|--------|
| 1 | `async` / `await` — o básico | ⬜ |
| 2 | `Task` e `Task<T>` | ⬜ |
| 3 | `Task.WhenAll` e `Task.WhenAny` | ⬜ |
| 4 | `CancellationToken` | ⬜ |
| 5 | Deadlocks e armadilhas comuns | ⬜ |
| 6 | `ValueTask` e quando usar | ⬜ |
| 7 | `IAsyncEnumerable<T>` — streams assíncronos | ⬜ |

### 2.3 ASP.NET Core — APIs REST

| # | Tópico | Status |
|---|--------|--------|
| 1 | Minimal APIs vs Controllers | ⬜ |
| 2 | Roteamento e Model Binding | ⬜ |
| 3 | Dependency Injection (DI) nativo do .NET | ⬜ |
| 4 | Middlewares e Pipeline de requisições | ⬜ |
| 5 | Configuração (`appsettings.json`, `IOptions<T>`) | ⬜ |
| 6 | Validação com Data Annotations e FluentValidation | ⬜ |
| 7 | Filtros (Action Filters, Exception Filters) | ⬜ |
| 8 | Versionamento de API | ⬜ |
| 9 | Swagger / OpenAPI | ⬜ |
| 10 | Health Checks | ⬜ |

### 2.4 Banco de Dados

| # | Tópico | Status |
|---|--------|--------|
| 1 | SQL Server / PostgreSQL — fundamentos SQL | ⬜ |
| 2 | Entity Framework Core — Code First | ⬜ |
| 3 | Migrations | ⬜ |
| 4 | Relacionamentos (1:1, 1:N, N:N) | ⬜ |
| 5 | Queries otimizadas e `.AsNoTracking()` | ⬜ |
| 6 | Repository Pattern | ⬜ |
| 7 | Unit of Work | ⬜ |
| 8 | Dapper — micro ORM para queries complexas | ⬜ |

### 2.5 Autenticação e Autorização

| # | Tópico | Status |
|---|--------|--------|
| 1 | JWT (JSON Web Tokens) | ⬜ |
| 2 | Identity no ASP.NET Core | ⬜ |
| 3 | OAuth 2.0 e OpenID Connect (conceitos) | ⬜ |
| 4 | Policies e Claims-based authorization | ⬜ |
| 5 | Refresh Tokens | ⬜ |

---

## 🟡 Nível 3 — Pleno

> Arquitetura, testes, qualidade de código e DevOps.

### 3.1 Princípios e Padrões de Design

| # | Tópico | Status |
|---|--------|--------|
| 1 | SOLID — aplicado em C# | ⬜ |
| 2 | Design Patterns: Factory, Strategy, Observer, Decorator, Builder | ⬜ |
| 3 | Domain-Driven Design (DDD) — conceitos básicos | ⬜ |
| 4 | Clean Code e refatoração | ⬜ |
| 5 | CQRS (Command Query Responsibility Segregation) | ⬜ |
| 6 | MediatR — Mediator Pattern | ⬜ |
| 7 | Result Pattern (evitar exceções para fluxo de controle) | ⬜ |

### 3.2 Arquitetura de Software

| # | Tópico | Status |
|---|--------|--------|
| 1 | Clean Architecture / Onion Architecture | ⬜ |
| 2 | Camadas: Domain, Application, Infrastructure, Presentation | ⬜ |
| 3 | Inversão de dependência na prática | ⬜ |
| 4 | Comunicação entre serviços (REST, gRPC, mensageria) | ⬜ |
| 5 | Event-Driven Architecture (conceitos) | ⬜ |

### 3.3 Testes

| # | Tópico | Status |
|---|--------|--------|
| 1 | Testes Unitários com xUnit | ⬜ |
| 2 | Mocking com Moq ou NSubstitute | ⬜ |
| 3 | Testes de Integração (WebApplicationFactory) | ⬜ |
| 4 | Testes de API (TestServer, HttpClient) | ⬜ |
| 5 | Cobertura de código | ⬜ |
| 6 | TDD — Test-Driven Development | ⬜ |
| 7 | Testes de carga com k6 ou NBomber | ⬜ |
| 8 | Property-Based Testing com FsCheck | ⬜ |

### 3.4 CI/CD e DevOps

| # | Tópico | Status |
|---|--------|--------|
| 1 | GitHub Actions — pipelines de build e teste | ⬜ |
| 2 | Azure DevOps Pipelines (alternativa) | ⬜ |
| 3 | Docker — containerização de apps .NET | ⬜ |
| 4 | Docker Compose — multi-container | ⬜ |
| 5 | Deploy automatizado (CD) | ⬜ |
| 6 | Ambientes (Dev, Staging, Production) | ⬜ |
| 7 | Secrets Management (User Secrets, Azure Key Vault) | ⬜ |

### 3.5 Logging, Monitoramento e Observabilidade

| # | Tópico | Status |
|---|--------|--------|
| 1 | Structured Logging com Serilog | ⬜ |
| 2 | Correlation IDs e rastreamento de requisições | ⬜ |
| 3 | OpenTelemetry — tracing distribuído | ⬜ |
| 4 | Métricas com Prometheus + Grafana | ⬜ |
| 5 | Application Insights (Azure) | ⬜ |

### 3.6 Performance e Memória

| # | Tópico | Status |
|---|--------|--------|
| 1 | Garbage Collector — como funciona no .NET | ⬜ |
| 2 | `Span<T>` e `Memory<T>` | ⬜ |
| 3 | Object Pooling | ⬜ |
| 4 | Caching: In-Memory e Distributed (Redis) | ⬜ |
| 5 | Response Caching e Output Caching | ⬜ |
| 6 | Profiling com dotnet-trace e BenchmarkDotNet | ⬜ |

---

## 🔴 Nível 4 — Sênior

> Sistemas distribuídos, cloud, liderança técnica.

### 4.1 Microserviços

| # | Tópico | Status |
|---|--------|--------|
| 1 | Quando usar microserviços vs monólito | ⬜ |
| 2 | API Gateway (Ocelot, YARP) | ⬜ |
| 3 | Service Discovery | ⬜ |
| 4 | Circuit Breaker e Retry (Polly) | ⬜ |
| 5 | Saga Pattern — transações distribuídas | ⬜ |
| 6 | Outbox Pattern | ⬜ |
| 7 | gRPC — comunicação entre serviços | ⬜ |

### 4.2 Mensageria e Eventos

| # | Tópico | Status |
|---|--------|--------|
| 1 | RabbitMQ — filas e exchanges | ⬜ |
| 2 | MassTransit — abstração de mensageria | ⬜ |
| 3 | Apache Kafka (conceitos e integração) | ⬜ |
| 4 | Event Sourcing | ⬜ |
| 5 | Azure Service Bus | ⬜ |

### 4.3 Cloud (Azure / AWS)

| # | Tópico | Status |
|---|--------|--------|
| 1 | Azure App Service — deploy de APIs | ⬜ |
| 2 | Azure Functions — serverless | ⬜ |
| 3 | Azure SQL / Cosmos DB | ⬜ |
| 4 | Azure Blob Storage | ⬜ |
| 5 | Azure Key Vault | ⬜ |
| 6 | Kubernetes (AKS) — orquestração de containers | ⬜ |
| 7 | Terraform / Bicep — Infrastructure as Code | ⬜ |

### 4.4 Segurança Avançada

| # | Tópico | Status |
|---|--------|--------|
| 1 | OWASP Top 10 — vulnerabilidades comuns | ⬜ |
| 2 | Rate Limiting e Throttling | ⬜ |
| 3 | CORS — configuração correta | ⬜ |
| 4 | HTTPS, HSTS e certificados | ⬜ |
| 5 | Input validation e sanitização | ⬜ |
| 6 | Zero Trust Architecture (conceitos) | ⬜ |

### 4.5 Qualidade e Liderança Técnica

| # | Tópico | Status |
|---|--------|--------|
| 1 | Code Review — boas práticas | ⬜ |
| 2 | Documentação técnica (ADRs, RFC, diagramas C4) | ⬜ |
| 3 | Mentoria de desenvolvedores júnior | ⬜ |
| 4 | Análise estática com SonarQube / Roslyn Analyzers | ⬜ |
| 5 | Feature Flags | ⬜ |
| 6 | A/B Testing e deploy canário | ⬜ |
| 7 | Estimativa e planejamento técnico | ⬜ |

---

## 📚 Recursos Recomendados

### Repositórios de Referência
- [milanm/DotNet-Developer-Roadmap](https://github.com/milanm/DotNet-Developer-Roadmap) — Roadmap visual por nível
- [MoienTajik/AspNetCore-Developer-Roadmap](https://github.com/MoienTajik/AspNetCore-Developer-Roadmap) — Foco em ASP.NET Core
- [kawser2133/csharp-dotnet-learning-path](https://github.com/kawser2133/csharp-dotnet-learning-path) — Learning path estruturado

### Documentação Oficial
- [Microsoft Learn — C#](https://learn.microsoft.com/pt-br/dotnet/csharp/)
- [Microsoft Learn — ASP.NET Core](https://learn.microsoft.com/pt-br/aspnet/core/)
- [Microsoft — Arquitetura de Microserviços .NET](https://learn.microsoft.com/dotnet/architecture/microservices/)

### Blogs
- [codewithmukesh.com](https://codewithmukesh.com/blog/dotnet-developer-roadmap/) — Roadmap .NET atualizado
- [ardalis.com](https://ardalis.com) — Clean Architecture e boas práticas
- [antondevtips.com](https://antondevtips.com/dotnet-senior-playbook) — Senior .NET Playbook

---

## 🏗️ Estrutura do Repositório (sugerida)

```
Roadmap_CSharp/
├── docs/
│   └── ROADMAP.md              ← este arquivo
├── src/
│   ├── 01-Fundamentos/
│   │   ├── TiposDeValorEReferencia/
│   │   ├── NullableTypes/
│   │   ├── PatternMatching/
│   │   └── ...
│   ├── 02-LINQ/
│   ├── 03-AsyncAwait/
│   ├── 04-AspNetCore/
│   ├── 05-EntityFramework/
│   ├── 06-Testes/
│   ├── 07-Arquitetura/
│   ├── 08-Docker/
│   ├── 09-CICD/
│   └── 10-Avancado/
├── tests/
├── .github/
│   └── workflows/
└── README.md
```

Cada pasta em `src/` conterá:
- Um projeto console ou API com exemplos executáveis
- Um `README.md` explicando o conceito
- Comentários detalhados no código

---

## 🎯 Ordem de Estudo Sugerida

1. **Fundamentos do C#** → Garante fluência na linguagem
2. **LINQ** → Você vai usar em absolutamente tudo
3. **Async/Await** → Base pra qualquer API moderna
4. **ASP.NET Core** → Construa sua primeira API
5. **Entity Framework + SQL** → Persista dados
6. **Testes** → Valide tudo que você constrói
7. **Docker + CI/CD** → Automatize o deploy
8. **Arquitetura** → Organize código em escala
9. **Cloud** → Deploy profissional
10. **Microserviços + Mensageria** → Sistemas distribuídos

---

*Última atualização: Julho 2026*

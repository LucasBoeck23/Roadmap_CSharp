# 🚀 Roadmap C# — Portfólio de Estudos

> Repositório-portfólio documentando minha evolução como desenvolvedor C#/.NET.
> Cada tópico contém **exemplos práticos executáveis** com explicações detalhadas.

---

## 📌 Sobre

Este não é apenas um repositório de estudos — é um **portfólio técnico vivo**.  
Cada pasta contém um mini-projeto que demonstra um conceito na prática, com:

- ✅ Código executável (rode e veja funcionando)
- ✅ README explicativo (entenda o conceito sem precisar pesquisar)
- ✅ Comentários no código (acompanhe a lógica passo a passo)
- ✅ Testes quando aplicável (prove que funciona)

---

## 🗂️ Estrutura

```
src/
├── 01-Fundamentos/          → Tipos, nullables, strings, coleções, pattern matching
├── 02-POO/                  → Classes, interfaces, generics, delegates, events
├── 03-LINQ/                 → Queries, filtros, agrupamentos, projeções
├── 04-AsyncAwait/           → Tasks, paralelismo, cancellation, streams
├── 05-AspNetCore/           → APIs REST, DI, middlewares, validação
├── 06-BancoDeDados/         → EF Core, migrations, Dapper, queries
├── 07-Autenticacao/         → JWT, Identity, OAuth, policies
├── 08-Testes/               → xUnit, Moq, integração, TDD
├── 09-Arquitetura/          → SOLID, Clean Architecture, CQRS, DDD
├── 10-Docker-CICD/          → Containers, GitHub Actions, deploy
├── 11-Performance/          → Caching, profiling, Span<T>, GC
├── 12-Microsservicos/       → gRPC, mensageria, Polly, sagas
└── 13-Cloud/                → Azure Functions, App Service, Kubernetes
```

---

## 🎯 Progresso

| Nível | Módulo | Status |
|-------|--------|--------|
| 🟢 Trainee | 01-Fundamentos | ⬜ |
| 🟢 Trainee | 02-POO | ⬜ |
| 🔵 Júnior | 03-LINQ | ⬜ |
| 🔵 Júnior | 04-AsyncAwait | ⬜ |
| 🔵 Júnior | 05-AspNetCore | ⬜ |
| 🔵 Júnior | 06-BancoDeDados | ⬜ |
| 🔵 Júnior | 07-Autenticacao | ⬜ |
| 🟡 Pleno | 08-Testes | ⬜ |
| 🟡 Pleno | 09-Arquitetura | ⬜ |
| 🟡 Pleno | 10-Docker-CICD | ⬜ |
| 🟡 Pleno | 11-Performance | ⬜ |
| 🔴 Sênior | 12-Microsservicos | ⬜ |
| 🔴 Sênior | 13-Cloud | ⬜ |

---

## 🏃 Como Rodar

### Pré-requisitos
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8) ou superior
- [Docker](https://www.docker.com/) (para módulos 10+)
- Um editor: VS Code, Visual Studio, ou Rider

### Executar um exemplo
```bash
# Navegue até o projeto desejado
cd src/01-Fundamentos/TiposDeValorEReferencia

# Execute
dotnet run
```

### Executar testes
```bash
# Rodar todos os testes
dotnet test

# Rodar testes de um módulo específico
dotnet test tests/08-Testes/
```

---

## 🧭 Roadmap Completo

Veja o [roadmap detalhado com todos os tópicos](docs/ROADMAP.md) — organizado por nível com checkboxes de progresso.

---

## 💡 Filosofia do Projeto

1. **Aprenda fazendo** — Cada conceito tem código executável, não só teoria
2. **Documente para ensinar** — Se você não consegue explicar, não aprendeu
3. **Construa incrementalmente** — Um módulo por vez, do simples ao complexo
4. **Mantenha real** — Exemplos simulam cenários de mercado, não exercícios acadêmicos

---

## 🛠️ Tecnologias Utilizadas

| Categoria | Tecnologia |
|-----------|-----------|
| Linguagem | C# 12+ |
| Framework | .NET 8+ |
| Web | ASP.NET Core |
| ORM | Entity Framework Core, Dapper |
| Testes | xUnit, Moq, FluentAssertions |
| Containers | Docker, Docker Compose |
| CI/CD | GitHub Actions |
| Mensageria | RabbitMQ, MassTransit |
| Cloud | Azure |
| Observabilidade | Serilog, OpenTelemetry |

---

## 📫 Contato

<!-- Adicione seus links aqui -->
- LinkedIn: [seu-perfil]
- GitHub: [seu-usuario]
- Email: [seu-email]

---

*Este repositório é atualizado continuamente conforme avanço nos estudos.*

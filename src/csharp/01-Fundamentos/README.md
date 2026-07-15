# Fundamentos do C#

> Os blocos básicos da linguagem — tipos, controle de fluxo, funções e estruturas.

---

## O que esse módulo cobre

| Arquivo | Conceito |
|---------|----------|
| `Variaveis.cs` | Tipos primitivos, `var`, `const`, nullable |
| `Condicoes.cs` | `if/else`, `switch`, ternário, pattern matching |
| `Loops.cs` | `for`, `foreach`, `while`, `break/continue` |
| `Funcoes.cs` | Métodos, `ref`, `out`, `params`, expression body |
| `Estruturas.cs` | Struct vs Class, enum, valor vs referência |

---

## Takeaways

- C# é **fortemente tipado** — erros de tipo são pegos em compilação
- `var` infere o tipo, mas não é dinâmico
- **Structs** = stack (cópia por valor) / **Classes** = heap (cópia por referência)
- Pattern matching no `switch` substitui cadeias de `if/else`

---

## Rodar

```bash
cd Projeto && dotnet run
```

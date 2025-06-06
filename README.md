# 💻 LeetCode Solutions em C#

Este repositório reúne soluções comentadas de desafios do [LeetCode](https://leetcode.com/) utilizando a linguagem **C#**.

A proposta é resolver **um desafio por vez**, com foco em:

- Lógica clara e eficiente 🧠
- Código limpo e bem estruturado ✨
- Uso de boas práticas e explicações didáticas 📚
- Explicações em vídeo no meu canal do YouTube: [@altamirjuniordev](https://www.youtube.com/@altamirjuniordev) 🎥

---

## 📌 Organização

- Todos os desafios estão no diretório `Problems/`, separados por arquivos.
- O ponto de entrada do projeto (`Program.cs`) é usado para chamar o desafio que está sendo trabalhado no momento.
- Os demais desafios ficam comentados, mas prontos para consulta e reexecução.

---

## 🛠️ Como executar

Você precisa do [.NET 6 ou 8 SDK](https://dotnet.microsoft.com/en-us/download) instalado.

```bash
git clone https://github.com/altamirjuniordev/LeetCode.git
cd LeetCodeSolutions
dotnet run
```

No `Program.cs`, descomente a linha referente ao problema que deseja executar.

---

## ✅ Desafios resolvidos

### 1. Two Sum (`Problems/TwoSum.cs`)

🔗 [LeetCode #1 - Two Sum](https://leetcode.com/problems/two-sum/)

> Dado um array de inteiros e um valor-alvo (`target`), o desafio é retornar os **índices de dois números** que somam exatamente esse valor.  
> A solução otimizada usa um **dicionário (hashmap)** para guardar os números já vistos e buscar complementos em tempo constante, alcançando **complexidade O(n)**.

Exemplo:

```csharp
nums = [2, 7, 11, 15]
target = 9
// Resultado: [0, 1]
```

---

### 2. Valid Parentheses (`Problems/ValidParentheses.cs`)

🔗 [LeetCode #20 - Valid Parentheses](https://leetcode.com/problems/valid-parentheses/)

> Verifica se uma string contendo apenas parênteses (`()`, `{}`, `[]`) é válida.  
> Uma string é considerada válida se os parênteses forem fechados na ordem correta e de forma balanceada.

A lógica usa uma **pilha (stack)** para empilhar os caracteres de abertura e verificar se cada fechamento corresponde ao topo da pilha.

```csharp
s = "()[]{}"
// Resultado: true

s = "(]"
// Resultado: false
```

---

## 🚧 Em desenvolvimento

- ✅ Problemas fáceis e médios
- 📌 Organização por temas no futuro (Strings, Arrays, Hash, Recursão, etc.)
- 📽️ Integração com vídeos explicativos no YouTube

---

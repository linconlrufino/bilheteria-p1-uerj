## [P1] - Atividade avaliativa sobre testes de unidade 
### Informações adicionais do projeto
- Versão .Net utilizada: .NET 8.0 - https://dotnet.microsoft.com/pt-br/download/dotnet/8.0 **.
- comando para execução dos testes **idade**:
- ![image](https://github.com/user-attachments/assets/45e1230a-1c45-4137-8de5-7cfbca53a2e0)
- ![image](https://github.com/user-attachments/assets/f4dab9ca-c244-432b-ad6d-7a3d6fb450ab)
---

---
### Regras do Sistema
- Cada visitante pode comprar até **5 bilhetes**.
- O valor do bilhete depende da **idade**:
    - **Crianças (≤ 12 anos)**: R$ 10
  - **Adultos (13 a 59 anos)**: R$ 30
  - **Idosos (≥ 60 anos)**: R$ 15
---

## Particionamento de Equivalência

### Idade

| Classe           | Descrição                     | Exemplo |
|------------------|-------------------------------|---------|
| Válida - Criança | Idade ≤ 12                    | 10      |
| Válida - Adulto  | 13 ≤ Idade ≤ 59               | 35      |
| Válida - Idoso   | Idade ≥ 60                    | 65      |
| Inválida         | Idade negativa ou exagerada   | -1, 150 |

### Quantidade de Bilhetes

| Classe           | Descrição                   | Exemplo |
|------------------|-----------------------------|---------|
| Válida           | 1 a 5                       | 3       |
| Inválida         | Menor que 1                 | 0       |
| Inválida         | Maior que 5                 | 6       |

---

## Análise de Valores Limite

### Idade
- **Limites de mudança de faixa:**
  - 12 (último valor para criança)
  - 13 (primeiro valor para adulto)
  - 59 (último valor para adulto)
  - 60 (primeiro valor para idoso)

### Quantidade de Bilhetes

- **Valores Válidos:**
  - 1 (mínimo válido)
  - 5 (máximo válido)

- **Valores Inválidos:**
  - 0 (abaixo do mínimo)
  - 6 (acima do máximo)

---

## Tabela de Casos de Teste

| ID  | Idade(s)             | Quantidade | Resultado Esperado                    | Técnica                           |
|-----|----------------------|------------|---------------------------------------|-----------------------------------|
| T1  | [10, 8]              | 2          | R$ 20                                 | Equivalência (criança)           |
| T2  | [30, 40, 50]         | 3          | R$ 90                                 | Equivalência (adulto)            |
| T3  | [65]                 | 1          | R$ 15                                 | Equivalência (idoso)             |
| T4  | [-1]                 | 1          | Erro, retorna valor Zero              | Equivalência inválida (idade)    |
| T5  | [25]                 | 0          | Erro, retorna valor Zero              | Limite inferior inválido         |
| T6  | [25]                 | 1          | R$ 30                                 | Limite inferior válido           |
| T7  | [25]                 | 5          | R$ 150                                | Limite superior válido           |
| T8  | [25]                 | 6          | Erro, retorna valor Zero              | Limite superior inválido         |
| T9  | [12]                 | 1          | R$ 10                                 | Limite superior (criança)        |
| T10 | [13]                 | 1          | R$ 30                                 | Limite inferior (adulto)         |
| T11 | [59]                 | 1          | R$ 30                                 | Limite superior (adulto)         |
| T12 | [60]                 | 1          | R$ 15                                 | Limite inferior (idoso)          |

---

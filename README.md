# 📅 App de Cadastro e Resumo de Eventos (.NET MAUI)

## 📝 Descrição

Este projeto é uma aplicação de exercício desenvolvida em **.NET MAUI** focada na criação de formulários e na implementação de lógica de negócios e cálculo dentro do *framework*.

O objetivo principal é criar uma tela para o **Cadastro de Eventos** e, após a submissão, exibir um **Resumo Completo** do evento em uma nova página, incluindo cálculos automáticos.

---

## ✨ Requisitos Técnicos e Funcionalidades

Este projeto foi desenvolvido para atender aos seguintes requisitos específicos da atividade:

### 1. Modelagem e Binding (MVVM)
* **Modelagem de Dados**: Utilização da classe `Evento` com todas as propriedades necessárias (Nome, Data Início/Término, Participantes, Local, Custo).
* **BindingContext**: Associação (`BindingContext`) da *View* (página de cadastro) diretamente à *Model* (`Evento`) para manipulação de dados em tempo real.

### 2. Lógica e Cálculo
* **Cálculo de Duração**: Implementação de lógica na *Model* para calcular a duração do evento em dias, utilizando as classes `DateTime` e `TimeSpan`.
* **Cálculo de Custo Total**: Lógica para calcular o custo total do evento: $CustoTotal = CustoPorParticipante \times NúmeroDeParticipantes$.

### 3. Navegação e Exibição
* **Navegação entre Páginas**: Transição da página de Cadastro para a página de Resumo.
* **Página de Resumo**: Exibe todos os dados do evento, incluindo a **Duração em dias** e o **Custo Total**, formatados corretamente.

## ⚙️ Dados Solicitados no Cadastro

A interface de Cadastro solicita os seguintes dados básicos do evento:

* Nome do evento
* Data de início
* Data de término
* Número de participantes
* Local do evento
* Custo por participante

## 🚀 Como Executar o Projeto

Siga estes passos para configurar e rodar o projeto em sua máquina de desenvolvimento:

### Pré-requisitos

* **Visual Studio 2022** (com a carga de trabalho de **.NET MAUI** instalada).
* **.NET 8**: Versão da *framework* utilizada no projeto.

### Instalação e Execução

1.  **Clone o Repositório:**
    ```bash
    git clone [https://github.com/brendahidalgos/NomeDoRepositorio.git](https://github.com/brendahidalgos/NomeDoRepositorio.git)
    ```
2.  **Abra no Visual Studio:**
    * Abra o arquivo de solução (`.sln`) no Visual Studio.
3.  **Execute o Aplicativo:**
    * Selecione o destino (ex: `Android Emulator` ou `Windows Machine`).
    * Pressione **F5** (Executar) para compilar e implantar o aplicativo.

---
## 👩‍💻 Desenvolvido em

* **Curso Técnico em Desenvolvimento de Sistemas**

## 📧 Contato

Se tiver alguma dúvida ou sugestão, pode me chamar!

* **GitHub**: [@brendahidalgos](https://github.com/brendahidalgos)

## ✍️ Autor

* **@brendahidalgos** - Aluna do curso de Análise e Desenvolvimento de Sistemas.

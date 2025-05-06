# ViraPágina
<br>
<br>



## Desenvolvido por:
Giovanna Cardozo  
Mateus Freitas
<br>

## Descrição do Projeto:

O ViraPágina é um sistema de gestão de biblioteca digital desenvolvido com foco na modernização dos processos de empréstimo, devolução e controle de livros. A plataforma tem como objetivo proporcionar uma experiência mais eficiente, segura e intuitiva tanto para os administradores quanto para os usuários da biblioteca.
Por meio da automação de tarefas manuais e da centralização das informações, o sistema permite acesso rápido a registros, controle preciso de prazos, aplicação de penalidades em casos de atraso ou danos aos livros, e organização de reservas. O sistema também contempla recursos como busca avançada com filtros, controle de histórico de empréstimos e casualidades, e geração automática de multas.
Projetado para ambiente desktop, o ViraPágina foi implementado utilizando C# com Windows Forms, estruturado sob o padrão MVC e com integração a um banco de dados MySQL, garantindo robustez e escalabilidade.
<br>
<br>

## Requisitos Funcionais:

### RF01 - Login e Recuperação de Senha
- O sistema deve permitir o login de usuários cadastrados.
- O sistema deve permitir o usuário recuperar a sua senha.

### RF02 - Cadastro, Atualização, Deleção e Visualização de Livros
- O sistema deve permitir o cadastro de livros.
- O sistema deve permitir atualizações aos registros de livros.
- O sistema deve permitir a deleção de registros de livros.
- O sistema deve permitir a visualização dos registros de livros.

### RF03 - Registro e Controle de Empréstimos
- O sistema deve permitir que o usuário faça o registro de empréstimos.
- O sistema deve permitir o controle de registro de empréstimos (Atualização, leitura e deleção).
- O sistema deve permitir o registro de casualidades em cada empréstimo.
- O sistema deve possibilitar que um usuário visualize o histórico de casualidades de um tomador.

### RF04 - Busca e Filtragem de Livros
- O sistema deve permitir que o usuário realize uma busca dos livros através das suas características (nome, data de lançamento, código, gênero, etc.).
- O sistema deve permitir o usuário realizar filtros nas buscas.

### RF05 - Registros de Reservas de Livros
- O sistema deve permitir que o usuário realize e controle registros a respeito de reservas de livros.

### RF06 - Controle de Atrasos e Penalidades
- O sistema deve fazer o controle dos atrasos e penalidades para tomadores que não respeitam os prazos do empréstimo.

### RF07 - Renovação de Empréstimos
- O sistema deve permitir que usuários renovem o empréstimo de tomadores.
<br>
<br>

## Requisitos Não Funcionais:

### RNF01 - Tecnologia e Plataforma
- O sistema deve ser implementado através de Windows Forms.
- O sistema deve ser compatível exclusivamente para desktop.
- O sistema deve ser implementado em C#.

### RNF02 - Banco de Dados
- O sistema deve possuir um banco de dados MySql.

### RNF03 - Arquitetura
- O sistema deve seguir o padrão MVC.
<br>
<br>

## Regras de Negócio:

### RN01 - Segurança de Acesso
- O sistema deve bloquear um usuário que errou a sua senha 3 vezes por 24 horas.

### RN02 - Prazos de Empréstimo
- O sistema deve cada empréstimo por um período fixo de 15 dias.

### RN03 - Restrição de Empréstimos
- O sistema deve impedir que usuários com penalidades pendentes façam empréstimos, até que as pendências sejam quitadas.

### RN04 - Renovação de Livros Reservados
- O sistema deve impedir que livros reservados sejam renovados.

### RN05 - Limite de Livros em Empréstimo
- O sistema deve limitar a quantidade de livros que os tomadores podem emprestar simultaneamente para 3 livros.

### RN06 - Liberação de Reservas
- O sistema deve liberar os livros reservados, em casos onde o livro reservado não foi resgatado, após 48 horas a partir do momento em que foi notificado disponível para o tomador.

### RN07 - Restrição por Danos aos Livros
- O sistema deve impossibilitar que tomadores que danifiquem os livros emprestem outros livros por um período de 30 dias. Em caso de recorrência, o tomador deve ser impossibilitado de emprestar qualquer livro por período indeterminado.

### RN08 - Identificação Única dos Livros
- O sistema deve garantir que cada livro tenha uma identificação única, permitindo a busca rápida pelo ISBN ou código interno.

### RN09 - Cálculo Automático de Multas
- O sistema deve calcular as multas automaticamente com base no número de dias de atraso, com um valor fixo de 5 reais por dia de atraso para cada livro.

### RN10 - Reserva de Livros Disponíveis
- O sistema só deve permitir a reserva de livros que estão emprestados.

## Apresentação:
- [Link](https://docs.google.com/presentation/d/18aAgKfP8k1C5HtvFbrITIqT0-pTgzXuJt4cF9tlsJDg/edit?usp=drive_link)


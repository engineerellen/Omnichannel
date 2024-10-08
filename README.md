# Omnichannel

#OBS: As respostas do questionário estão neste repositório em um arquivo *.txt#

1. Contexto
Componentes:

    UI: Interage com o sistema via cliente (CLI, web, mobile).
    API MultiChannelAPI: O núcleo do sistema, onde reside a lógica de negócios.
    ViaCEP API: Serviço externo para validação de endereços.
    SQL Server: Banco de dados que armazena informações dos clientes.
    Serviços Azure: Infraestrutura de suporte (deploy, logging, etc.).

2. Container
Abaixo mostra a divisão do sistema e como será a iteração com o usuário:

No nível de containers, detalhamos os principais serviços e seus relacionamentos. Cada serviço containerizado pode escalar independentemente:
Componentes:

    API MultiChannelAPI: Implementada em ASP.NET Core, exposta como uma API RESTful.
    Database (SQL Server): Armazena as informações persistentes, como clientes.

    
Aqui está a visão de Componentes e Código do projeto OmniClientHub, apresentando a organização interna e os relacionamentos entre as camadas.
![image](https://github.com/user-attachments/assets/27292554-aabb-4652-9945-17fac0f62d79)

1. Componentes (Nível de Camadas)

O projeto segue uma arquitetura limpa e desacoplada, onde cada camada tem uma responsabilidade clara:
Camadas:

    Controllers: Camada de entrada para os clientes, responsável por processar requisições HTTP.
    Services: Contém a lógica de negócios. Implementa a validação de clientes e interage com outros serviços (como o ViaCEP).
    Repositories: Interage com o banco de dados, gerenciando a persistência dos dados.

2. Camadas e Responsabilidades

    Controller:
        Responsabilidade: Processa as requisições HTTP e retorna as respostas adequadas.

    Service:
        Responsabilidade: Lógica de negócios e regras de validação.

    Repository:
        Responsabilidade: Comunicação com o banco de dados, persistência de entidades.


Para rodar o projeto:
1- Clonar o projeto
2- Executar o comando Update-Database no Package Manage Console

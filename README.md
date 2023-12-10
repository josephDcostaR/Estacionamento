# DIO - Trilha .NET - Fundamentos
www.dio.me

## Desafio de projeto
RESOLVIDO!!!

Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta
Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

**EncontarVeiculos**: Recebe uma entrada da placa do veículo do usuario, e busca por ela dentro do sistama. Caso não haja nenhum, exibir a mensagem "Não encontramos o veículo".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encontrar veículo
5. Encerrar


## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

## Resolução

1. Os metodos que estavão incompletos, foram completados corretamente, no de a adicionar veiculos, foi implementado uma forma de receber as entradas do usuário, além disso foi adicionado um tratamento caso o usuário tente colocar a mesma placa no sistema.

2. No método de remoção foi implementado a entrada do usuário, e a lógica de cobrançã do estacionamento.

3. No método de listagem, foi a adicionado um loop for para realizar a listagem dos veículos presentes no sistema.

4. De adcional, adicionamos um novo método ao sistema o (4. Encontrar veículo) que encontra um veículo especifico dentro do sistema, ele funciona de foema simples o mesmo espera uma entrada do usuário e com ela busno sistema se essa entrada existe e retorna a mesma para ele.

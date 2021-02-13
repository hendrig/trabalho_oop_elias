# TRABALHO DE AVALIAÇÃO 1

O objetivo deste trablalho é identificar o quanto de conteúdo foi absorvido nas aulas.

O trabalho consiste em fazer um gerador de Fábricas.
Cada fábrica usa um tipo específico de insumo para produzir um tipo específico de produto.

Abaixo, o que deve ser feito para alterar o código já existente:

- Crie uma interface para os produtos com os seguintes métodos:
  - Usar (retorna uma string)
- Crie uma interface para os insumos
  - RetornarNome (retorna uma string)
- Crie os seguintes produtos:
  - Sapato
  - Batedeira
  - Microondas
  - Tenis

- Crie os seguintes insumos:
  - Couro
  - Tecido
  - Plástico
  - Metal
- Modifique a fábrica para que ela receba no construtor o insumo e o produto
- Modifique a fábrica para que ela retorne, no método Usar, o nome do insumo (ex. Tênis de Tecido)

- Por fim, crie as seguintes fábricas:
  - Uma fábrica de Tênis de Tecido
  - Uma fábrica de Batedeiras de Plástico
  - Uma fábrica de Microondas de Metal
  - Uma fábrica de Sapatos de Couro

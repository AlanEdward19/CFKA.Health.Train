
# CFKA.Health.Train

Microserviço de criação de fichas de treino para musculação.

Tem intuito de facilitar a criação de fichas de treino, para personal trainers, professores de educação fisica, ou até mesmo intusiastas que queiram montar seus proprios treinos com facilidade.

Estado atual reflete apenas a criação de algumas agrupamentos musculares (além dos grupos principais, que ja se encontram presentes), criações de exercicios utilizando repetições, series e quais agrupamentos fortalece naquele exercicio, fichas de treino que por enquanto ainda não podem ser exportadas, atualizações constantes a caminho.

Proxima Atualização esperada: Possibilidade de exportar para um Excel personalizado.

Uma interface Angular está sendo desenvolvida para uma melhor e mais simplificada utilização desse microserviço:
[Link para o repositorio](https://github.com/AlanEdward19/CFKA.Health.Train.Front)

## Estruturação

Neste projeto encontramos conceitos de:
- CQRS (Separação de Commands and Queries)
- Generic Programming
- DRY
- SOLID
- KISS
- DDD
- Repository Pattern
- Factory Pattern
- Arquitetura em camadas
- Conteinerização (Docker)

## Outros microserviços correlatos

No momento somente o CFKA.Health.Train está sendo desenvolvido, porém futuramente terá integração direto com o CFKA.Health.Nutrition que terá foco em nutrição.

Possivelmente uma tela em Angular será desenvolvida e englobará ambos microserviços, porém a funcionalidade de exportação para Excel se manterá em todos.
## Autores

- [@AlanEdward19](https://github.com/AlanEdward19)


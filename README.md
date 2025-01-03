# ExempleTestC#
## Codi
Crea una classe de tipus calculadora que hi ha les funcions:
- Sumar
- Restar
- Multiplicar
- Dividir
- ComptaDivisions (dividend, divisor) : Compta les vegades que dividend es pot dividir per divisor.

## Tests
També, s'han implementat els testos per algunes d'aquestes funcions. S'ha utilitzat la tècnica dels límits:
- Quan implementem funcions, no només ens preocupem que funcionin amb dades "normals", sinó també amb dades que són atípiques o extremes.
- Per assegurar que una funció és robusta, fem proves amb valors que estan als límits o fora del que és esperat, com ara números molt grans, molt petits, negatius o zero.

Aquesta tècnica assegura que una funció es comporta correctament en escenaris extrems o propers als límits dels valors possibles d'entrada.

### Per què és important fer proves de límits?
- Evitar errors inesperats: Els límits són on sovint es produeixen errors, com divisions per zero, overflows o resultats incorrectes.
- Garantir la robustesa del codi: Assegura que la funció funcioni correctament independentment dels valors d'entrada.
- Preparació per a situacions reals: En l'ús del programa, no es pot garantir que els usuaris sempre introdueixin dades "normals". 

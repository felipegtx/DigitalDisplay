Kanui
=====

Solução para o problema '[digital display](https://github.com/Kanui/QueroSerKanui/tree/master/testes/digital-display)'.

Reconhecimento dos dígitos
------

Por meio da [seguinte função de Hash](https://github.com/felipegtx/Kanui/blob/master/Kanui/Parsers/DataParserResult.cs#L186), é possível extrair um identificador único para cada grupo de caracteres que representam um dado dígito no display:

`acumulator += (((y ^ d) + (xRef ^ d)) / 3) + (d * y);`

Onde *d* é o resultado da função **GetHashCode** do char em cada uma das posições do display.

Tecnologia utilizada
------

* .Net Framework 4.5 (C#)
* .MSTests




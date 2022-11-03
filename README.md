# Testen von BeEquivalentTo

Während des Testens ist mir aufgefallen, dass immer nur die Parameter und Werte der ersten Klasse mit den Parametern und Werten der zweiten Klasse verglichen werden. Allerdings nicht automatisch andersherum.


## Verschiedene Testklassen (In jeder Testklasse wurde A mit B verglichen - Für den Vergleich von B mit A wurden extra Testklassen verwendet)

#### Test1
Gleiche Parameter mit gleichen Werten
Vergleich A » B = Erfolg (Erwartet: Erfolg)
Vergleich B » A = Erfolg (Erwartet: Erfolg)

#### Test2
Gleiche Parameter mit verschiedenen Werten
Vergleich A » B = Fehlschlag (Erwartet: Fehlschlag)
Vergleich B » A = Fehlschlag (Erwartet: Fehlschlag)

#### Test3
Verschiedene Parameter mit verschiedenen Werten
Vergleich A » B = Fehlschlag (Erwartet: Fehlschlag)
Vergleich B » A = Fehlschlag (Erwartet: Fehlschlag)

#### Test4
Verschiedene Parameter mit gleichen Werten (Bei übereinstimmenden Parametern wurden die gleichen Werte verwendet)
Vergleich A » B = Fehlschlag (Erwartet: Fehlschlag)
Vergleich B » A = Fehlschlag (Erwartet: Fehlschlag)

#### Test5
Gleiche Parameter (Klasse B fehlt jedoch ein Parameter) mit gleichen Werten
Vergleich A » B = Erfolg (Erwartet: Fehlschlag)
Vergleich B » A = Fehlschlag (Erwartet: Fehlschlag)

#### Test6
Gleiche Parameter (Klasse B fehlt jedoch ein Parameter) mit verschiedenen Werten
Vergleich A » B = Fehlschlag (Erwartet: Fehlschlag)
Vergleich B » A = Fehlschlag (Erwartet: Fehlschlag)

## Verschiedene Testklassen mit Fix (In jeder Testklasse wurde A mit B und B mit A verglichen)
#### Test1
Gleiche Parameter mit gleichen Werten
Vergleich = Erfolg (Erwartet: Erfolg)

#### Test2
Gleiche Parameter mit verschiedenen Werten
Vergleich = Fehlschlag (Erwartet: Fehlschlag)

#### Test3
Verschiedene Parameter mit verschiedenen Werten
Vergleich = Fehlschlag (Erwartet: Fehlschlag)

#### Test4
Verschiedene Parameter mit gleichen Werten (Bei übereinstimmenden Parametern wurden die gleichen Werte verwendet)
Vergleich = Fehlschlag (Erwartet: Fehlschlag)

#### Test5
Gleiche Parameter (Klasse B fehlt jedoch ein Parameter) mit gleichen Werten
Vergleich = Fehlschlag (Erwartet: Fehlschlag)

#### Test6
Gleiche Parameter (Klasse B fehlt jedoch ein Parameter) mit verschiedenen Werten
Vergleich = Fehlschlag (Erwartet: Fehlschlag)
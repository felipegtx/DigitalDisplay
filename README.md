Digital Display
-----
This repo was first created as a solution to the problem proposed here: '[digital display](https://github.com/Kanui/QueroSerKanui/tree/master/testes/digital-display)'. 

It takes a pattern in the form of a 3x3 matrix and represents it as a number from **zero** to **nine**. It can learn from different representations of that given data and adapt to respond accordingly. 

![delorean](http://a1.mzstatic.com/us/r30/Purple/v4/c3/92/c6/c392c6b0-a568-7b6f-618f-f1be00103350/screen480x480.jpeg)

Digit recognition
-----
Based on the [following hash function](https://github.com/felipegtx/DigitalDisplay/blob/master/Project/DigitalDisplay/Parsers/DataParserResult.cs#L186), it's possible to extract a unique identifier for each 3x3 array group that represents a single digit on the display:

```csharp
acumulator += (((y ^ d) + (xRef ^ d)) / 3) + (d * y);
```

Where *d* is the result from the call to **GetHashCode** - using the char on each of the 3x3 position in the training set matrix.

Available training sets
-----

  - [Digital1](https://github.com/felipegtx/DigitalDisplay/tree/master/Training%20sets/Digital1)
```
 _     _  _     _  _  _  _  _ 
| |  | _| _||_||_ |_   ||_||_|
|_|  ||_  _|  | _||_|  ||_| _|
```

  - [Digital2](https://github.com/felipegtx/DigitalDisplay/tree/master/Training%20sets/Digital2)
```
 _     _  _     _  _  _  _  _ 
[ ]  | _] _]|_|[_ [_   |[_][_]
[_]  |[_  _]  | _][_]  |[_] _]
```

  - [Digital3](https://github.com/felipegtx/DigitalDisplay/tree/master/Training%20sets/Digital3)
```
 _     _  _     _  _  _  _  _ 
< >  | _> _><_|<_ <_   |<_><_>
[_]  |[_  _]  | _][_]  |[_] _]
```

Execution modes
-----
The compilation output is the file *DigitalDisplay.exe* that can be used in two different ways:

#### Training mode

The program will treat the input parameter as the path to a text file that shall be used to calculate the identification hash for each of the ten digits we are concerned. As a result the program will update  the index file that comes with the solution (*map.DigitalDisplay*) and this will be the active pattern for future recognition.

##### DISCLAIMER:
Collisions are identified in the output as ```'/!\\invalid format/!\'``` and keep the index file from being updated.

##### Example:
```bash
DigitalDisplay.exe "t>C:\\MyFile.txt"
```

#### Identification mode
Based on the active index file the program will try to identify the digits inside the provided feature file.

Parser errors outputs as: ```'/!\\invalid format/!\'```

##### Example:
```bash
DigitalDisplay.exe "i>C:\\Myfile.txt"
```

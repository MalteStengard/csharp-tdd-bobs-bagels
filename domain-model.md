#Domain Models In Here

Second Domain Model
| Classes         | Methods                          | Scenario                                | Outputs                                             |
|-----------------|----------------------------------|-----------------------------------------|-----------------------------------------------------|
| `Core`		  | `add(string name)`               | if key is not in dict                   | adds key/value to basket dict and returns true      |
|				  |					                 | if key is in dict		               | triggers warning and returns false                  |	
|                 | `remove(string name)`            | if key is in dict                       | removes key/value from basket dict and returns true |
|				  |						             | if key is not in dict                   | triggers warning and returns false                  |
|				  | `changeBasketCapacity(int size)` | int is sent as arg                      | adjusts the basket capacity to size arg             |
|				  | `getBasketCapacity()`            | method is called                        | returns the current basket capacity                 |
|				  | `getCurrentBasketContent()`      | method is called                        | returns the length of the basket dict               |


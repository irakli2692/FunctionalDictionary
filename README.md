# FunctionalDictionary
analogue of kotlin's 'when' operator as a dictionary.

example:
IFunctionalDictionary<int, string> dictionary = new FunctionalDictionary<int, string>
                                                {
                                                  {num => num > 5, "more than 5"},
                                                  {num => num % 2 == 0, "even number"},
                                                  {num => num < 15, "less than 15"}
                                                }
                                                
dictionary[7] value is "more than 5"

dictionary[1] value is "less than 15"

dictionary[4] value is "even number"

dictionary[20] value is "more than 5"




/*
One class owns another class completely

Meaning:
Strong relationship
If parent is destroyed, child also dies

Real life:
Car HAS Engine
Engine cannot exist without Car (in this design)

| Type        | Strength | Dependency        | Example               |
| ----------- | -------- | ----------------- | --------------------- |
| Association | Weak     | No ownership      | Teacher–Student       |
| Aggregation | Medium   | Partial ownership | University–Department |
| Composition | Strong   | Full ownership    | Car–Engine            |

*/
class Engine
{
}

class Car
{
    private Engine engine = new Engine();
}
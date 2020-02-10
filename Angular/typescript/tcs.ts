import { hcltech, birlasoft } from "./hcl";

class test
{
    constructor()
    {
        var obj = new hcltech(111,'karan');
        var obj1= new birlasoft(152, 'birla');
        obj.Display();
        obj1.Display();
    }

}

var temp = new test();
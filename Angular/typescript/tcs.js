"use strict";
exports.__esModule = true;
var hcl_1 = require("./hcl");
var test = /** @class */ (function () {
    function test() {
        var obj = new hcl_1.hcltech(111, 'karan');
        var obj1 = new hcl_1.birlasoft(152, 'birla');
        obj.Display();
        obj1.Display();
    }
    return test;
}());
var temp = new test();

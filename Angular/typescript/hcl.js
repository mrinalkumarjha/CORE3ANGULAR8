"use strict";
exports.__esModule = true;
var hcltech = /** @class */ (function () {
    function hcltech(c, n) {
        this.code = c;
        this.name = n;
    }
    hcltech.prototype.Display = function () {
        console.log(this.code);
        console.log(this.name);
    };
    return hcltech;
}());
exports.hcltech = hcltech;
var birlasoft = /** @class */ (function () {
    function birlasoft(c, n) {
        this.code = c;
        this.name = n;
    }
    birlasoft.prototype.Display = function () {
        console.log(this.code);
        console.log(this.name);
    };
    return birlasoft;
}());
exports.birlasoft = birlasoft;
// here memory of hcl allocated in heap.
// var obj = new hcl(120, 'mrinal');
// obj.Display();

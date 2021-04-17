function Rectangle(a, b) {
    const obj = {};
    obj.length = a;
    obj.width = b;
    obj.perimeter = 2 * (obj.length +  obj.width);
    obj.area = obj.length * obj.width;

    return obj;
}

let rectangle = new Rectangle(4,5);
console.log(rectangle.length);
console.log(rectangle.width);
console.log(rectangle.perimeter);
console.log(rectangle.area);
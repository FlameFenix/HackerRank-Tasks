function Polygon(input) {
    const obj = {};
    obj.sideOne = input[0];
    obj.sideTwo = input[1];
    obj.length = input[2];

    obj.perimeter = function () {
        let sum = 0;
        for (let index = 0; index < input.length; index++) {
            const element = input[index];
            sum += element;
        }
        return sum;
    }
    return obj;
}

let triangle = new Polygon([3, 4, 5])

const rectangle = new Polygon([10, 20, 10, 20]);
const square = new Polygon([10, 10, 10, 10]);
const pentagon = new Polygon([10, 20, 30, 40, 43]);

console.log(rectangle.perimeter());
console.log(square.perimeter());
console.log(pentagon.perimeter());
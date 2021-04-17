function getCount(objects) {
    let counter = 0;
    for (let i = 0; i < objects.length; i++) {
        const elements = objects[i];
        if (elements.x == elements.y) {
            counter++;
        }
    }
    return counter;
}
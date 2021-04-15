function getSecondLargest(nums) {
    let secondLargestValue = -1;
    let firstLargestValue = -1;
    for (let index = 0; index < nums.length; index++) {
        const element = nums[index];
        if (firstLargestValue < element) {
            firstLargestValue = element;
        }
    }

    for (let index = 0; index < nums.length; index++) {
        const element = nums[index];
        if(secondLargestValue < element && element != firstLargestValue) {
            secondLargestValue = element;
        }
    }
    console.log(secondLargestValue); // return secondLargestValue;
}

getSecondLargest([2, 3, 6, 6, 5]);

// let data: number | string = 42;
// data = '42';

export interface Duck {
    name: string;
    legs: number;
    makeSound: (sound:string) => void;
}

const duck1: Duck = {
    name: 'Huey',
    legs: 2,
    makeSound: (sound: string) => console.log(sound)
}
const duck2: Duck = {
    name: 'Duey',
    legs: 2,
    makeSound: (sound: string) => console.log(sound)
}
// const duckExtra = {
//     name: 'Luey',
//     legs: 2,
//     makeQuack: () => console.log('quack')
// }

// duck1.makeSound('quack');
// duckExtra.makeQuack();

export const ducks = [duck1, duck2]
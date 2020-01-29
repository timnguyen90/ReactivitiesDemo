let data : string | number;
// data sẽ có kiểu string hoặc number

export interface ICar{
    color: string;
    model: string;
    topSpeed?:number;
    // Thuộc tính này có cũng được mà không có cũng không sao.
}
// Cả hai khai báo sau điều hợp lệ
const car1: ICar = {
    color:'blue',
    model: 'BMW'
}
const car2: ICar = {
    color: 'red',
    model: 'Mercedes',
    topSpeed: 100
}

// Trả về kiểu number
const multiply = (x:number, y:number) => {
    return (x*y);
}


export const cars = [car1, car2];

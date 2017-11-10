let stringTrue1 = "{[]()}"
let stringFalse1 = "{[()}"
let stringTrue2 = "{[()]()[()][]()}"
let stringFalse2 = "{[()][][()](()}"

console.log(verificador(stringTrue1))
console.log(verificador(stringFalse1))
console.log(verificador(stringTrue2))
console.log(verificador(stringFalse2))

function verificador(val) {
    let stack = []
    for (let i = 0; i < val.length; i++) {
        let ch = val.charAt(i)
        let lastChar = stack[stack.length - 1]
        if (ch == '{' || ch == '[' || ch == '(') {
            stack.push(ch)
        } else if (ch == '}' && lastChar == '{' || ch == ']' && lastChar == '[' || ch == ')' && lastChar == '(' ) {
            stack.pop()
        } else {
            return false
        }
    }
    if (stack.length != 0){
        return false
    }
    return true
}

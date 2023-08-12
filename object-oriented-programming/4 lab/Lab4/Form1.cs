using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Figures;

namespace Lab4
{
    public partial class Form1 : Form
    {
        private Stack<Operator> operators = new Stack<Operator>();
        private Stack<Operand> operands = new Stack<Operand>();

        int sq_count = 0;
        public Form1()
        {
            InitializeComponent();
            Init.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Init.pen = new Pen(Color.Black, 3);
            Init.pictureBox = pictureBox1;
            ShapeContainer figure_list = new ShapeContainer();
        }

        private void textBoxInputString_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                operators.Clear();
                operands.Clear();
                
                string sourceExpression = textBoxInputString.Text.Replace(" ", "");
                for (int i = 0; i < sourceExpression.Length; i++)
                {
                    char c = sourceExpression[i];
                    if (IsNotOperation(c))
                    {
                        if (!Char.IsDigit(c))
                        {
                            operands.Push(new Operand(c));
                            while (i < sourceExpression.Length - 1 && IsNotOperation(sourceExpression[i + 1]))
                            {
                                string temp_str = operands.Pop().value.ToString() + sourceExpression[i + 1].ToString();
                                operands.Push(new Operand(temp_str));
                                i++;
                            }
                        }
                        else if (Char.IsDigit(c))
                        {
                            operands.Push(new Operand(c.ToString()));
                            while (i < sourceExpression.Length - 1 && Char.IsDigit(sourceExpression[i + 1])
                                && IsNotOperation(sourceExpression[i + 1]))
                            {
                                int temp_num = Convert.ToInt32(operands.Pop().value.ToString()) * 10 +
                                    (int)Char.GetNumericValue(sourceExpression[i + 1]);
                                operands.Push(new Operand(temp_num));
                                i++;
                            }
                        }
                    }

                    else if ((c == 'S') || (c == 'M') || (c == 'D') || (c == 'I'))
                    {
                        if (operators.Count == 0)
                        {
                            operators.Push(OperatorContainer.FindOperator(c));
                        }
                    }
                    else if (sourceExpression[i] == '(')
                    {
                        operators.Push(OperatorContainer.FindOperator(sourceExpression[i]));
                    }
                    else if (c == ')')
                    {
                        do
                        {
                            if (operators.Peek().symbolOperator == '(')
                            {
                                operators.Pop();
                                break;
                            }
                            if (operators.Count == 0)
                            {
                                break;
                            }
                        }
                        while (operators.Peek().symbolOperator != '(');
                    }
                }

                if (operators.Count > 0)
                {
                    if (IsNotOperation(operators.Peek().symbolOperator))
                    {
                        MessageBox.Show("Введенной операции не существует.");
                        comboBox1.Items.Add("Введенной операции не существует.");
                    }
                    else
                    {
                        if (ParameterCheck())
                        {
                            SelectingPerformingOperation(operators.Pop());
                        }
                        else
                        {
                            MessageBox.Show("Команда введена некорректно.");
                            comboBox1.Items.Add("Команда введена некорректно.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Вы не ввели операцию.");
                    comboBox1.Items.Add("Вы не ввели операцию.");
                }
            }
        }
        private bool CheckName(string name)
        {
            foreach (Square asq in ShapeContainer.figureList)
            {
                if (asq.user_name == name)
                {
                    return false;
                }  
            }
            return true;
        }
        private void SelectingPerformingOperation(Operator op)
        {
            if (op.symbolOperator == 'S')
            {
                if (operands.Count == 4)
                {
                    sq_count += 1;
                    int a = Convert.ToInt32(operands.Pop().value.ToString());
                    int y = Convert.ToInt32(operands.Pop().value.ToString());
                    int x = Convert.ToInt32(operands.Pop().value.ToString());
                    string name = operands.Pop().value.ToString();
                    if (CheckName(name))
                    {
                        if (Init.Coords_check(x, y, a, a))
                        {
                            Square figure = new Square(sq_count, x, y, a, name);
                            op = new Operator(figure.Draw, 'S');
                            ShapeContainer.AddFigure(figure);
                            comboBox1.Items.Add($"Квадрат {figure.user_name} отрисован");
                            op.operatorMethod();
                        }
                        else
                        {
                            MessageBox.Show("Фигура вышла за границы.");
                            comboBox1.Items.Add("Фигура вышла за границы.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Фигура с таким именем уже сужествует.");
                        comboBox1.Items.Add("Фигура с таким именем уже сужествует.");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Опертор S принимает 4 аргумента.");
                    comboBox1.Items.Add("Неверное число аргументов для оператора S.");
                }
            }
            else if (op.symbolOperator == 'M')
            {
                if (operands.Count == 3)
                {
                    Square figure = null;
                    int y = Convert.ToInt32(operands.Pop().value.ToString());
                    int x = Convert.ToInt32(operands.Pop().value.ToString());
                    string name = operands.Pop().value.ToString();
                    foreach (Square f in ShapeContainer.figureList)
                    {
                        if(f.user_name == name)
                        {
                            figure = (Square)f;
                        }
                    }
                    if (figure != null)
                    {
                        if (Init.Coords_check(figure.x + x, figure.y + y, figure.w, figure.h))
                        {
                            figure.MoveTo(x, y);
                            comboBox1.Items.Add($"Фигура {figure.user_name} успешно перемещена");
                        }
                        else
                        {
                            MessageBox.Show("Фигура вышла за границы.");
                            comboBox1.Items.Add("Фигура вышла за границы.");
                        }
                    }
                    else
                    {
                        comboBox1.Items.Add($"Фигуры {name} не существует");
                    }
                }
                else
                {
                    MessageBox.Show("Опертор M принимает 3 аргумента.");
                    comboBox1.Items.Add("Неверное число аргументов для оператора M.");
                }
            }
            else if (op.symbolOperator == 'I')
            {
                if (operands.Count == 2)
                {
                    Square figure = null;
                    int ca = Convert.ToInt32(operands.Pop().value.ToString());
                    string name = operands.Pop().value.ToString();
                    foreach (Square f in ShapeContainer.figureList)
                    {
                        if (f.user_name == name)
                        {
                            figure = (Square)f;
                        }
                    }
                    if (figure != null)
                    {
                        if (Init.Coords_check(figure.x, figure.y, ca, ca))
                        {
                            figure.w = ca;
                            figure.h = ca;
                            figure.DeleteF(figure, false);
                            figure.Draw();
                            comboBox1.Items.Add($"Фигура {figure.user_name} изменена.");
                        }
                        else
                        {
                            MessageBox.Show("Фигура вышла за границы.");
                            comboBox1.Items.Add("Фигура вышла за границы.");
                        }
                    }
                    else
                    {
                        comboBox1.Items.Add($"Фигуры {name} не существует");
                    }
                }
                else
                {
                    MessageBox.Show("Опертор I принимает 2 аргумента.");
                    comboBox1.Items.Add("Неверное число аргументов для оператора I.");
                }
            }
            else if (op.symbolOperator == 'D')
            {
                if (operands.Count == 1)
                {
                    Square figure = null;
                    string name = operands.Pop().value.ToString();
                    foreach (Square f in ShapeContainer.figureList)
                    {
                        if (f.user_name == name)
                        {
                            figure = (Square)f;
                        }
                    }
                    if (figure != null)
                    {
                        figure.DeleteF(figure, true);
                        comboBox1.Items.Add($"Фигура {figure.user_name} удалена.");
                    }
                    else
                    {
                        comboBox1.Items.Add($"Фигуры {name} не существует.");
                    }
                }
                else
                {
                    MessageBox.Show("Опертор D принимает 1 аргумент.");
                    comboBox1.Items.Add("Неверное число аргументов для оператора D.");
                }
            }
        }
        private bool IsNotOperation(char item)
        {
            if (!(item == 'D' || item == 'M' || item == 'S' || item == 'I' || item == ',' || item == '(' || item == ')'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ParameterCheck()
        {
            Stack<Operand> stack = new Stack<Operand>(operands);
            int stack_lenght = stack.Count;
            for (int i = 0; i < stack_lenght; i++)
            {
                Operand operand = stack.Pop();
                if (i == 0)
                {
                    if (!(operand.value is string) && !(operand.value is char))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!(operand.value is int))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
#include "pch.h"
#include "TurnRightBrick.h"
#include "Script.h"
#include "Object.h"
#include "Interpreter.h"

TurnRightBrick::TurnRightBrick(FormulaTree *rotation, Script *parent) :
	Brick(TypeOfBrick::TurnRightBrick, parent),
	m_rotation(rotation)
{
}

void TurnRightBrick::Execute()
{
	auto rotation = m_parent->GetParent()->GetRotation();
	rotation += Interpreter::Instance()->EvaluateFormulaToFloat(m_rotation, m_parent->GetParent());
	rotation = (rotation > 360) ? rotation - 360 : rotation; //rotation not greater than 360
	m_parent->GetParent()->SetRotation(rotation);
}
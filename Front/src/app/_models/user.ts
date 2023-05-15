import { Validator } from 'fluentvalidation-ts';
import { Role } from './role';

export class User {
    id!: string;
    title!: string;
    firstName!: string;
    lastName!: string;
    email!: string;
    role!: Role;
    isDeleting: boolean = false;
}

export class UserValidator extends Validator<User> {
    constructor() {
      super();
  
      this.ruleFor('title')
        .notEmpty()
        .withMessage('Please enter your title');
  
      this.ruleFor('firstName')
        .notEmpty()
        .withMessage('Please enter your firstName');

      this.ruleFor('lastName')
        .notEmpty()
        .withMessage('Please enter your lastName');

        this.ruleFor('email')
        .notEmpty()
        .withMessage('Please enter your email');

        this.ruleFor('role')
        .notEmpty()
        .withMessage('Please enter your role');
    }
  } 
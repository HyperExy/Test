import { Component, VERSION } from '@angular/core';
import { FormBuilder } from '@angular/forms';

@Component({
    selector: 'my-app',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})
export class AppComponent {
    checkoutForm = this.formBuilder.group({
        name: '',
        email: '',
        phone: '',
        theme: '',
        text: '',
    });
    constructor(
        private formBuilder: FormBuilder,
    ) { }
    onSubmit(): void {
        console.warn('Сообщение было отправлено', this.checkoutForm.value);
        this.checkoutForm.reset();
        Program.Post();
    }
}

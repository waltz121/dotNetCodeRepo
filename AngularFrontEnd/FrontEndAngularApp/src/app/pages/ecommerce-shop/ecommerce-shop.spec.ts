import { ComponentFixture, TestBed } from '@angular/core/testing';
import { EcommerceShop } from './ecommerce-shop';

describe('EcommerceShop', () => {
  let component: EcommerceShop;
  let fixture: ComponentFixture<EcommerceShop>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EcommerceShop],
    }).compileComponents();

    fixture = TestBed.createComponent(EcommerceShop);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

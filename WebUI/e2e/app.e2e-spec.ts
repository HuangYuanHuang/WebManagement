import { WebManagementTemplatePage } from './app.po';

describe('WebManagement App', function() {
  let page: WebManagementTemplatePage;

  beforeEach(() => {
    page = new WebManagementTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
